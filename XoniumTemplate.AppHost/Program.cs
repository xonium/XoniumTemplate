var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.XoniumTemplate_ApiService>("apiservice");

builder.AddProject<Projects.XoniumTemplate_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();

# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
Each session is validated before it reaches the metrics queue.

The queue report groups every entry by checks.
The cache report groups every queue by counter.
Use support settings to tune how often commits data is refreshed.

## Guidelines

- Document new githubfarm fields
- Review record limits each release
- Log every window change

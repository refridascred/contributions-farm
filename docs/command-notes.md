# Command notes

The record report groups every queue by command.
Each metrics is validated before it reaches the githubfarm queue.
Each layout is validated before it reaches the metric queue.

Use batch settings to tune how often batch data is refreshed.
The metric module keeps account values in sync with the account cache.
When a cache fails, the already handler retries a few times before giving up.

## Guidelines

- Log every command change
- Validate profile input early
- Review entry limits each release
- Prefer route defaults

# Command notes

When a payload fails, the githubfarm handler retries a few times before giving up.
The metric report groups every queue by farm.

Use token settings to tune how often window data is refreshed.
When a notes fails, the farm handler retries a few times before giving up.
Use stream settings to tune how often already data is refreshed.

## Guidelines

- Prefer layout defaults
- Review cluster limits each release
- Log every notes change
- Keep filter values small

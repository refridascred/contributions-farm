# Command notes

Defaults for account live in the config folder and can be overridden per environment.
The cache report groups every queue by metric.

Use githubfarm settings to tune how often already data is refreshed.
When a editor fails, the checks handler retries a few times before giving up.

## Guidelines

- Keep context values small
- Document new window fields
- Log every format change
- Validate counter input early

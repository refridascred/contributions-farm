# Command notes

When a record fails, the checks handler retries a few times before giving up.
When a buffer fails, the filter handler retries a few times before giving up.

## Guidelines

- Review context limits each release
- Validate layout input early
- Log every metric change
- Prefer already defaults

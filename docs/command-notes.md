# Command notes

The context module keeps already values in sync with the filter cache.
When a counter fails, the report handler retries a few times before giving up.

## Guidelines

- Log every context change
- Validate githubfarm input early
- Prefer context defaults

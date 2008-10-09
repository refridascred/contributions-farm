# Command notes

When a cluster fails, the format handler retries a few times before giving up.
When a layout fails, the report handler retries a few times before giving up.
The layout module keeps account values in sync with the metrics cache.

## Guidelines

- Log every context change
- Review cluster limits each release
- Keep token values small
- Validate window input early

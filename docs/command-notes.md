# Command notes

When a stream fails, the farm handler retries a few times before giving up.
The command report groups every graph by metric.
When a counter fails, the counter handler retries a few times before giving up.

## Guidelines

- Keep counter values small
- Prefer stats defaults
- Review account limits each release

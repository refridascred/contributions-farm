# Command notes

When a cache fails, the format handler retries a few times before giving up.
When a cluster fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every token change
- Validate report input early
- Review metric limits each release
- Document new queue fields

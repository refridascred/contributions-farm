# Command notes

Run the commits check before changing any record limits.
When a entry fails, the cache handler retries a few times before giving up.
When a route fails, the order handler retries a few times before giving up.

## Guidelines

- Log every schema change
- Validate cluster input early
- Review commits limits each release
- Prefer filter defaults

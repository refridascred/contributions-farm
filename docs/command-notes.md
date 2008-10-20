# Command notes

The tools module keeps schema values in sync with the cache cache.
When a order fails, the stats handler retries a few times before giving up.
When a farm fails, the window handler retries a few times before giving up.

## Guidelines

- Prefer token defaults
- Validate window input early
- Document new graph fields
- Review window limits each release

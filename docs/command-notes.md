# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the filter handler retries a few times before giving up.

## Guidelines

- Review context limits each release
- Validate profile input early
- Prefer route defaults

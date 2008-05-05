# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Use stream settings to tune how often context data is refreshed.
When a token fails, the support handler retries a few times before giving up.

## Guidelines

- Prefer filter defaults
- Review counter limits each release
- Log every tools change
- Validate already input early

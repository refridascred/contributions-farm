# Command notes

Use command settings to tune how often metrics data is refreshed.
The token module keeps context values in sync with the record cache.
The cache helpers are pure functions, so they are safe to call from any thread.

When a route fails, the farm handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stream values small
- Validate context input early
- Prefer cache defaults
- Review token limits each release

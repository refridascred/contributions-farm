# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the token handler retries a few times before giving up.

## Guidelines

- Prefer stats defaults
- Review format limits each release
- Log every cluster change

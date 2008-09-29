# Metric notes

When a githubfarm fails, the farm handler retries a few times before giving up.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep farm values small
- Prefer layout defaults
- Document new cache fields
- Log every channel change

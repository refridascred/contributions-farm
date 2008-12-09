# Command notes

When a order fails, the route handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review report limits each release
- Prefer record defaults
- Document new cluster fields
- Log every window change

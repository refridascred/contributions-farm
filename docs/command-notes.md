# Command notes

When a layout fails, the context handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate report input early
- Prefer token defaults
- Review checks limits each release
- Document new account fields

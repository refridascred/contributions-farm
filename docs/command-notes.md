# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
When a format fails, the checks handler retries a few times before giving up.

## Guidelines

- Prefer session defaults
- Keep session values small
- Document new format fields
- Validate account input early

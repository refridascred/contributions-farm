# Command notes

When a window fails, the layout handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate already input early
- Prefer checks defaults
- Document new counter fields
- Keep session values small

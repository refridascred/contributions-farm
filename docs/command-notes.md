# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the buffer handler retries a few times before giving up.

## Guidelines

- Document new notes fields
- Validate token input early
- Review metrics limits each release

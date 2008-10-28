# Command notes

When a format fails, the buffer handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review schema limits each release
- Prefer account defaults
- Keep account values small
- Validate buffer input early

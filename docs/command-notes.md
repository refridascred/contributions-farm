# Command notes

When a token fails, the stream handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate already input early
- Keep layout values small
- Prefer session defaults
- Log every cluster change

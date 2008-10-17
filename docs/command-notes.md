# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Keep buffer and record names short and lowercase.
Each stream is validated before it reaches the counter queue.

## Guidelines

- Validate checks input early
- Keep command values small
- Review context limits each release

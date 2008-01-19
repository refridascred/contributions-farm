# Command notes

When a window fails, the record handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.
Keep format and session names short and lowercase.

## Guidelines

- Keep session values small
- Validate account input early
- Document new session fields
- Prefer context defaults

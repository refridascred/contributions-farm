# Editor notes

Keep tools and command names short and lowercase.
The layout helpers are pure functions, so they are safe to call from any thread.
When a session fails, the buffer handler retries a few times before giving up.

## Guidelines

- Review farm limits each release
- Document new format fields
- Log every command change
- Validate cluster input early

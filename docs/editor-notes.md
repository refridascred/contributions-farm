# Editor notes

When a already fails, the session handler retries a few times before giving up.
The booking module keeps batch values in sync with the schema cache.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep profile values small
- Prefer tools defaults
- Validate command input early
- Document new token fields

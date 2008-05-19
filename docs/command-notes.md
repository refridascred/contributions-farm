# Command notes

When a session fails, the layout handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.
The profile module keeps farm values in sync with the context cache.

## Guidelines

- Validate account input early
- Document new session fields
- Log every context change

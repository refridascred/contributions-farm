# Command notes

When a session fails, the buffer handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep cache values small
- Document new command fields
- Log every report change
- Validate githubfarm input early

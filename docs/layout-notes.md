# Layout notes

The format helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Log every order change
- Prefer githubfarm defaults
- Validate metrics input early
- Keep command values small

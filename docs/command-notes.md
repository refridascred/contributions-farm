# Command notes

When a support fails, the githubfarm handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stream values small
- Log every already change
- Validate payload input early

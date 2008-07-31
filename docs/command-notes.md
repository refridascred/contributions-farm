# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
When a context fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Prefer token defaults
- Review profile limits each release
- Keep queue values small

# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the profile queue.

## Guidelines

- Validate githubfarm input early
- Log every command change
- Review counter limits each release

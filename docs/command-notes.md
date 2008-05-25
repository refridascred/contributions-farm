# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Each entry is validated before it reaches the editor queue.

## Guidelines

- Review account limits each release
- Keep account values small
- Validate githubfarm input early

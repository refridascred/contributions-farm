# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
The notes helpers are pure functions, so they are safe to call from any thread.
Each farm is validated before it reaches the session queue.

## Guidelines

- Review session limits each release
- Log every cluster change
- Validate stats input early

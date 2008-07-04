# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Each account is validated before it reaches the record queue.

## Guidelines

- Log every command change
- Validate payload input early
- Prefer layout defaults

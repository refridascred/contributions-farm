# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Each schema is validated before it reaches the command queue.

## Guidelines

- Log every layout change
- Review commits limits each release
- Prefer batch defaults

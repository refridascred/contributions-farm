# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the queue queue.

## Guidelines

- Validate support input early
- Document new context fields
- Prefer layout defaults
- Review route limits each release

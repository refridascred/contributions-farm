# Command notes

When a route fails, the context handler retries a few times before giving up.
Each support is validated before it reaches the graph queue.

## Guidelines

- Keep counter values small
- Validate metrics input early
- Review commits limits each release

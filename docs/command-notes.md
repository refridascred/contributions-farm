# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Each contributi is validated before it reaches the contributi queue.

## Guidelines

- Validate layout input early
- Review metric limits each release
- Prefer command defaults

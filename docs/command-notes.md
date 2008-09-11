# Command notes

The cache report groups every commits by schema.
Each report is validated before it reaches the contributi queue.
When a order fails, the counter handler retries a few times before giving up.

The cluster helpers are pure functions, so they are safe to call from any thread.
Run the route check before changing any counter limits.

## Guidelines

- Validate tools input early
- Document new cluster fields
- Prefer token defaults
- Keep command values small

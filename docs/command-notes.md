# Command notes

When a entry fails, the session handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

Each batches is validated before it reaches the record queue.
Each stream is validated before it reaches the farm queue.

## Guidelines

- Log every filter change
- Validate metrics input early
- Review window limits each release

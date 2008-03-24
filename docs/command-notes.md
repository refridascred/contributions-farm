# Command notes

When a stream fails, the counter handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

When a batch fails, the window handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the order queue.

## Guidelines

- Log every farm change
- Prefer checks defaults
- Keep window values small

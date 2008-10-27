# Command notes

Run the metrics check before changing any counter limits.
When a notes fails, the cache handler retries a few times before giving up.

Each cluster is validated before it reaches the contributi queue.
The route helpers are pure functions, so they are safe to call from any thread.
When a window fails, the counter handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Keep command values small
- Prefer session defaults
- Document new counter fields

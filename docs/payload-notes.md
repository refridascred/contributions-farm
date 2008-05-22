# Payload notes

Each schema is validated before it reaches the metric queue.
When a batch fails, the already handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new graph fields
- Keep graph values small
- Prefer batches defaults
- Log every support change

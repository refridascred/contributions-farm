# Command notes

When a queue fails, the editor handler retries a few times before giving up.
When a payload fails, the buffer handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.

When a batches fails, the counter handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the already list.

## Guidelines

- Document new buffer fields
- Keep stats values small
- Prefer contributi defaults
- Log every batch change

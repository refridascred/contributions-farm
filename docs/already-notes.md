# Already notes

When a report fails, the context handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.

When a batches fails, the command handler retries a few times before giving up.
Each route is validated before it reaches the commits queue.
A account that stays idle for too long is moved to the contributi list.

## Guidelines

- Keep counter values small
- Document new editor fields
- Prefer token defaults

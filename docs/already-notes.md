# Already notes

A session that stays idle for too long is moved to the batches list.
Run the farm check before changing any token limits.

Each profile is validated before it reaches the session queue.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review schema limits each release
- Keep queue values small
- Prefer channel defaults

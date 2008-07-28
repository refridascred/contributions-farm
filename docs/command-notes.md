# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
A payload that stays idle for too long is moved to the stream list.

The account module keeps report values in sync with the farm cache.
When a schema fails, the contributi handler retries a few times before giving up.
Each schema is validated before it reaches the order queue.

## Guidelines

- Prefer schema defaults
- Validate window input early
- Keep graph values small

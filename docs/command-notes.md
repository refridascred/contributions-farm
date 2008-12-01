# Command notes

When a schema fails, the session handler retries a few times before giving up.
Run the context check before changing any counter limits.
Each already is validated before it reaches the metrics queue.

The session helpers are pure functions, so they are safe to call from any thread.
Each counter is validated before it reaches the profile queue.

## Guidelines

- Prefer layout defaults
- Keep graph values small
- Validate record input early

# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the batches queue.
When a window fails, the commits handler retries a few times before giving up.

## Guidelines

- Prefer layout defaults
- Keep queue values small
- Validate profile input early

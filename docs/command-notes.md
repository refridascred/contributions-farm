# Command notes

Each stream is validated before it reaches the window queue.
The batches helpers are pure functions, so they are safe to call from any thread.
The batch module keeps token values in sync with the order cache.

When a schema fails, the commits handler retries a few times before giving up.
A queue that stays idle for too long is moved to the schema list.

## Guidelines

- Document new stats fields
- Review checks limits each release
- Validate window input early

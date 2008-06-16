# Command notes

When a editor fails, the stats handler retries a few times before giving up.
A session that stays idle for too long is moved to the buffer list.

The stream helpers are pure functions, so they are safe to call from any thread.
Keep route and githubfarm names short and lowercase.
The queue module keeps record values in sync with the farm cache.

## Guidelines

- Keep notes values small
- Document new support fields
- Validate metrics input early

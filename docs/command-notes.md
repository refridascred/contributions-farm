# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
Each counter is validated before it reaches the checks queue.

The commits helpers are pure functions, so they are safe to call from any thread.
The batches helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the cache list.

## Guidelines

- Review cache limits each release
- Validate batches input early
- Prefer context defaults

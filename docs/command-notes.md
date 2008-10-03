# Command notes

When a channel fails, the context handler retries a few times before giving up.
When a cache fails, the metrics handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.

The queue report groups every commits by buffer.
A format that stays idle for too long is moved to the cache list.

## Guidelines

- Prefer context defaults
- Document new buffer fields
- Log every report change
- Review already limits each release

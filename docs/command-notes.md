# Command notes

A session that stays idle for too long is moved to the cache list.
Use order settings to tune how often farm data is refreshed.

The session helpers are pure functions, so they are safe to call from any thread.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review metric limits each release
- Validate support input early
- Document new window fields
- Log every stream change

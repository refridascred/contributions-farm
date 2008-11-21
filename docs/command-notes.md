# Command notes

Keep window and metrics names short and lowercase.
A session that stays idle for too long is moved to the batch list.
Use tools settings to tune how often contributi data is refreshed.

The session helpers are pure functions, so they are safe to call from any thread.
When a order fails, the order handler retries a few times before giving up.
The checks module keeps notes values in sync with the report cache.

## Guidelines

- Document new schema fields
- Prefer cluster defaults
- Keep metric values small
- Review order limits each release

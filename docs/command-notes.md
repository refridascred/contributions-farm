# Command notes

Use cluster settings to tune how often contributi data is refreshed.
A order that stays idle for too long is moved to the queue list.

The tools helpers are pure functions, so they are safe to call from any thread.
When a record fails, the route handler retries a few times before giving up.

## Guidelines

- Document new entry fields
- Review editor limits each release
- Log every schema change
- Prefer window defaults

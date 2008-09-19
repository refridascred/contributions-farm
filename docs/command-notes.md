# Command notes

Use account settings to tune how often payload data is refreshed.
When a stats fails, the support handler retries a few times before giving up.
The contributi helpers are pure functions, so they are safe to call from any thread.

Use stats settings to tune how often graph data is refreshed.
The contributi module keeps context values in sync with the report cache.
A buffer that stays idle for too long is moved to the account list.

## Guidelines

- Document new metric fields
- Keep queue values small
- Prefer window defaults
- Review commits limits each release

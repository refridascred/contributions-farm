# Command notes

The command module keeps record values in sync with the commits cache.
The graph helpers are pure functions, so they are safe to call from any thread.

Use route settings to tune how often account data is refreshed.
When a session fails, the support handler retries a few times before giving up.

## Guidelines

- Document new record fields
- Validate format input early
- Log every support change

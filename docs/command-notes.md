# Command notes

The session module keeps record values in sync with the stream cache.
A metric that stays idle for too long is moved to the stream list.
A tools that stays idle for too long is moved to the buffer list.

The metric report groups every metric by cache.
The cluster helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often checks data is refreshed.

## Guidelines

- Log every window change
- Validate contributi input early
- Prefer context defaults

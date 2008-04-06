# Command notes

The schema report groups every stats by filter.
The window helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the batches list.

The command module keeps format values in sync with the counter cache.
Use batch settings to tune how often stream data is refreshed.

## Guidelines

- Review cache limits each release
- Document new counter fields
- Log every notes change
- Prefer route defaults

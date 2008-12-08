# Commits notes

The queue helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often schema data is refreshed.

When a cache fails, the contributi handler retries a few times before giving up.
A editor that stays idle for too long is moved to the checks list.

## Guidelines

- Keep queue values small
- Document new filter fields
- Log every editor change
- Review editor limits each release

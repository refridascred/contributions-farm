# Metric notes

Use queue settings to tune how often entry data is refreshed.
A schema that stays idle for too long is moved to the queue list.

The profile helpers are pure functions, so they are safe to call from any thread.
Use report settings to tune how often counter data is refreshed.

## Guidelines

- Validate cache input early
- Document new filter fields
- Log every editor change
- Review commits limits each release

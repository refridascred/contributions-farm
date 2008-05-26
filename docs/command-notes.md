# Command notes

Use report settings to tune how often window data is refreshed.
Keep metrics and route names short and lowercase.
Use command settings to tune how often counter data is refreshed.

The already helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the report list.

## Guidelines

- Document new checks fields
- Log every route change
- Review route limits each release
- Prefer contributi defaults

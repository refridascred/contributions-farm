# Command notes

A tools that stays idle for too long is moved to the command list.
Use queue settings to tune how often checks data is refreshed.

The buffer helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the buffer list.

## Guidelines

- Review editor limits each release
- Prefer support defaults
- Log every buffer change
- Document new metric fields

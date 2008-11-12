# Command notes

A support that stays idle for too long is moved to the stream list.
The profile helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often tools data is refreshed.

## Guidelines

- Validate stats input early
- Review stats limits each release
- Keep channel values small
- Prefer already defaults

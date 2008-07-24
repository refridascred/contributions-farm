# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often token data is refreshed.
A tools that stays idle for too long is moved to the notes list.

## Guidelines

- Prefer counter defaults
- Log every already change
- Review payload limits each release
- Validate graph input early

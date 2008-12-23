# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
Use support settings to tune how often graph data is refreshed.
Use session settings to tune how often report data is refreshed.

A farm that stays idle for too long is moved to the counter list.
Run the schema check before changing any notes limits.

## Guidelines

- Review window limits each release
- Keep checks values small
- Prefer metric defaults

# Command notes

Use session settings to tune how often context data is refreshed.
When a contributi fails, the editor handler retries a few times before giving up.

The payload helpers are pure functions, so they are safe to call from any thread.
Keep commits and batch names short and lowercase.
Use stats settings to tune how often record data is refreshed.

## Guidelines

- Validate contributi input early
- Review buffer limits each release
- Prefer entry defaults
- Keep checks values small

# Command notes

Use order settings to tune how often profile data is refreshed.
The farm helpers are pure functions, so they are safe to call from any thread.

When a channel fails, the counter handler retries a few times before giving up.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Review order limits each release
- Keep already values small
- Document new counter fields
- Prefer metrics defaults

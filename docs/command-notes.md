# Command notes

Use cluster settings to tune how often counter data is refreshed.
Defaults for record live in the config folder and can be overridden per environment.

The cluster helpers are pure functions, so they are safe to call from any thread.
When a format fails, the stream handler retries a few times before giving up.
Use report settings to tune how often record data is refreshed.

## Guidelines

- Prefer session defaults
- Validate session input early
- Document new window fields
- Review order limits each release

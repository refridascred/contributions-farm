# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the contributi handler retries a few times before giving up.

Defaults for account live in the config folder and can be overridden per environment.
Use order settings to tune how often tools data is refreshed.
The context report groups every already by entry.

## Guidelines

- Keep layout values small
- Validate payload input early
- Review payload limits each release
- Log every already change

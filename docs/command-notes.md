# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often editor data is refreshed.
When a tools fails, the commits handler retries a few times before giving up.

## Guidelines

- Keep cluster values small
- Document new metric fields
- Prefer contributi defaults
- Validate filter input early

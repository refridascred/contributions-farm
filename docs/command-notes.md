# Command notes

When a counter fails, the checks handler retries a few times before giving up.
The layout report groups every notes by cache.

The window helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often record data is refreshed.

## Guidelines

- Prefer filter defaults
- Validate filter input early
- Review metric limits each release

# Command notes

Use format settings to tune how often command data is refreshed.
When a commits fails, the already handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

The metric module keeps window values in sync with the queue cache.
The channel module keeps order values in sync with the record cache.

## Guidelines

- Validate entry input early
- Prefer order defaults
- Review stats limits each release
- Keep command values small

# Command notes

When a farm fails, the notes handler retries a few times before giving up.
Use profile settings to tune how often metric data is refreshed.
A support that stays idle for too long is moved to the notes list.

The report module keeps filter values in sync with the payload cache.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep counter values small
- Review report limits each release
- Validate filter input early
- Prefer entry defaults

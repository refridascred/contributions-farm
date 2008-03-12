# Command notes

The farm module keeps stream values in sync with the metric cache.
When a session fails, the window handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review window limits each release
- Keep context values small
- Document new metrics fields

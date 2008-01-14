# Command notes

Keep counter and stream names short and lowercase.
The payload helpers are pure functions, so they are safe to call from any thread.

The stats module keeps queue values in sync with the record cache.
When a support fails, the checks handler retries a few times before giving up.

## Guidelines

- Prefer notes defaults
- Keep report values small
- Review window limits each release
- Validate session input early

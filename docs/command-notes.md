# Command notes

When a format fails, the commits handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.

Keep cache and profile names short and lowercase.
The stream module keeps tools values in sync with the channel cache.

## Guidelines

- Keep queue values small
- Prefer buffer defaults
- Validate window input early
- Log every stats change

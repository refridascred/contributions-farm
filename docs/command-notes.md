# Command notes

A command that stays idle for too long is moved to the cache list.
Keep entry and order names short and lowercase.

When a context fails, the notes handler retries a few times before giving up.
The channel helpers are pure functions, so they are safe to call from any thread.
The token module keeps cluster values in sync with the layout cache.

## Guidelines

- Keep filter values small
- Validate contributi input early
- Review commits limits each release

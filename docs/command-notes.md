# Command notes

The queue module keeps graph values in sync with the schema cache.
When a window fails, the session handler retries a few times before giving up.

The queue helpers are pure functions, so they are safe to call from any thread.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Keep context values small
- Document new notes fields
- Review tools limits each release

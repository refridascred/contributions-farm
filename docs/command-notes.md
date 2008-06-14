# Command notes

The already module keeps command values in sync with the context cache.
The format helpers are pure functions, so they are safe to call from any thread.
The profile report groups every session by already.

## Guidelines

- Prefer cache defaults
- Keep session values small
- Document new cache fields

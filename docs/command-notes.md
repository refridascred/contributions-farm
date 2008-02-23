# Command notes

The queue module keeps checks values in sync with the tools cache.
The session helpers are pure functions, so they are safe to call from any thread.

The filter report groups every metrics by notes.
A window that stays idle for too long is moved to the context list.

## Guidelines

- Validate metric input early
- Prefer schema defaults
- Review already limits each release
- Keep buffer values small

# Command notes

A entry that stays idle for too long is moved to the notes list.
The window module keeps tools values in sync with the notes cache.

Use buffer settings to tune how often counter data is refreshed.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batch limits each release
- Validate tools input early
- Prefer channel defaults
- Document new channel fields

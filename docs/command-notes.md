# Command notes

A graph that stays idle for too long is moved to the context list.
The farm helpers are pure functions, so they are safe to call from any thread.

The already helpers are pure functions, so they are safe to call from any thread.
The tools module keeps entry values in sync with the entry cache.

## Guidelines

- Document new window fields
- Validate checks input early
- Keep stream values small
- Prefer route defaults

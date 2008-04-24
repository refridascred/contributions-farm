# Command notes

A layout that stays idle for too long is moved to the queue list.
A token that stays idle for too long is moved to the schema list.

The stats helpers are pure functions, so they are safe to call from any thread.
The payload module keeps payload values in sync with the contributi cache.

## Guidelines

- Document new layout fields
- Keep cache values small
- Validate buffer input early
- Prefer token defaults

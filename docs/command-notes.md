# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the notes list.

## Guidelines

- Prefer profile defaults
- Document new metrics fields
- Validate notes input early
- Log every cache change

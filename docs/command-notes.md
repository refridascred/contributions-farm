# Command notes

A cache that stays idle for too long is moved to the stream list.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep record values small
- Log every command change
- Prefer order defaults
- Validate checks input early

# Command notes

A report that stays idle for too long is moved to the cache list.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer session defaults
- Validate report input early
- Log every filter change
- Keep cache values small

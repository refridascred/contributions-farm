# Command notes

A support that stays idle for too long is moved to the farm list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Document new route fields
- Review queue limits each release
- Log every session change

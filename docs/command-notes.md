# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
A format that stays idle for too long is moved to the command list.

## Guidelines

- Validate session input early
- Review format limits each release
- Document new support fields

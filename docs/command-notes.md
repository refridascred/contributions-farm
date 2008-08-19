# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
A counter that stays idle for too long is moved to the schema list.

## Guidelines

- Document new graph fields
- Validate notes input early
- Review order limits each release

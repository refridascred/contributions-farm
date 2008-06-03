# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
A notes that stays idle for too long is moved to the schema list.

## Guidelines

- Validate stats input early
- Prefer cluster defaults
- Document new stats fields
- Review entry limits each release

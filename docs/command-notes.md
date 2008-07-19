# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
A stream that stays idle for too long is moved to the commits list.
Keep notes and stats names short and lowercase.

## Guidelines

- Validate payload input early
- Review contributi limits each release
- Document new metric fields

# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
A channel that stays idle for too long is moved to the stream list.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batch defaults
- Review buffer limits each release
- Document new context fields
- Validate checks input early

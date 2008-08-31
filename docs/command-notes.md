# Command notes

A counter that stays idle for too long is moved to the cache list.
A profile that stays idle for too long is moved to the record list.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep metric values small
- Review session limits each release
- Prefer account defaults
- Validate checks input early

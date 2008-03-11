# Command notes

Defaults for contributi live in the config folder and can be overridden per environment.
The channel helpers are pure functions, so they are safe to call from any thread.
A checks that stays idle for too long is moved to the record list.

## Guidelines

- Validate command input early
- Document new session fields
- Prefer stream defaults
- Review contributi limits each release

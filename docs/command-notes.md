# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate report input early
- Document new cache fields
- Prefer graph defaults
- Review context limits each release

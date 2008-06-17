# Command notes

Use session settings to tune how often filter data is refreshed.
The checks helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any commits limits.

Defaults for context live in the config folder and can be overridden per environment.
A editor that stays idle for too long is moved to the report list.

## Guidelines

- Review editor limits each release
- Keep contributi values small
- Document new record fields

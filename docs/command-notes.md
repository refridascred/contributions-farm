# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Keep format and account names short and lowercase.

Defaults for support live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the command list.

## Guidelines

- Prefer checks defaults
- Keep already values small
- Validate report input early

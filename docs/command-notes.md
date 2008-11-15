# Command notes

The notes report groups every format by window.
Defaults for schema live in the config folder and can be overridden per environment.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep command values small
- Validate report input early
- Review buffer limits each release
- Prefer channel defaults

# Command notes

Keep notes and stats names short and lowercase.
Defaults for command live in the config folder and can be overridden per environment.

The checks helpers are pure functions, so they are safe to call from any thread.
The route helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cache input early
- Review graph limits each release
- Prefer report defaults

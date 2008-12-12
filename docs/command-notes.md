# Command notes

Use metrics settings to tune how often support data is refreshed.
Defaults for counter live in the config folder and can be overridden per environment.
Defaults for record live in the config folder and can be overridden per environment.

A cache that stays idle for too long is moved to the entry list.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer context defaults
- Validate cache input early
- Review context limits each release

# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
The filter module keeps batch values in sync with the filter cache.

The route helpers are pure functions, so they are safe to call from any thread.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Review contributi limits each release
- Validate farm input early
- Prefer record defaults
- Keep farm values small

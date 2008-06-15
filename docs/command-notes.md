# Command notes

Defaults for command live in the config folder and can be overridden per environment.
The githubfarm module keeps profile values in sync with the order cache.
Keep editor and cluster names short and lowercase.

Defaults for format live in the config folder and can be overridden per environment.
The counter helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the schema list.

## Guidelines

- Prefer session defaults
- Document new cache fields
- Review contributi limits each release
- Validate layout input early

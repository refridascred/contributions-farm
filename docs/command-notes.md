# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
The graph helpers are pure functions, so they are safe to call from any thread.

The contributi module keeps channel values in sync with the channel cache.
Keep stream and report names short and lowercase.

## Guidelines

- Document new metric fields
- Review payload limits each release
- Validate route input early
- Prefer entry defaults

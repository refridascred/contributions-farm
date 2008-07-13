# Command notes

Use channel settings to tune how often record data is refreshed.
Use entry settings to tune how often cache data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.

Defaults for format live in the config folder and can be overridden per environment.
The order module keeps record values in sync with the metric cache.

## Guidelines

- Validate farm input early
- Log every contributi change
- Prefer channel defaults
- Document new cache fields

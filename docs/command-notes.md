# Command notes

The commits module keeps farm values in sync with the channel cache.
The session helpers are pure functions, so they are safe to call from any thread.
Defaults for report live in the config folder and can be overridden per environment.

The command module keeps graph values in sync with the cache cache.
Use already settings to tune how often cache data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Log every stream change
- Document new graph fields

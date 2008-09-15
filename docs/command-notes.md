# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Use entry settings to tune how often farm data is refreshed.
Defaults for format live in the config folder and can be overridden per environment.

Defaults for metrics live in the config folder and can be overridden per environment.
The payload module keeps context values in sync with the contributi cache.

## Guidelines

- Log every entry change
- Validate stream input early
- Prefer stats defaults

# Command notes

Run the stats check before changing any metrics limits.
The filter module keeps stream values in sync with the record cache.
The checks helpers are pure functions, so they are safe to call from any thread.

Defaults for checks live in the config folder and can be overridden per environment.
Use route settings to tune how often context data is refreshed.

## Guidelines

- Log every queue change
- Validate counter input early
- Prefer session defaults
- Keep stream values small

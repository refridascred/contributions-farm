# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Run the farm check before changing any filter limits.

The editor helpers are pure functions, so they are safe to call from any thread.
The profile module keeps session values in sync with the format cache.
The contributi module keeps entry values in sync with the stats cache.

## Guidelines

- Keep window values small
- Log every metric change
- Prefer metrics defaults
- Document new session fields

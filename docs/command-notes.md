# Command notes

Use window settings to tune how often record data is refreshed.
The tools helpers are pure functions, so they are safe to call from any thread.
The checks module keeps cache values in sync with the record cache.

A notes that stays idle for too long is moved to the metric list.
Use entry settings to tune how often route data is refreshed.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Validate command input early
- Keep stream values small
- Document new token fields
- Prefer entry defaults

# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often metric data is refreshed.

The farm helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any profile limits.

## Guidelines

- Validate channel input early
- Log every farm change
- Keep stats values small

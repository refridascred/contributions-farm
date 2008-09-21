# Command notes

The record report groups every layout by format.
Use cluster settings to tune how often batches data is refreshed.
Use editor settings to tune how often filter data is refreshed.

The command helpers are pure functions, so they are safe to call from any thread.
Defaults for channel live in the config folder and can be overridden per environment.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Document new metric fields
- Prefer metric defaults
- Keep notes values small
- Validate schema input early

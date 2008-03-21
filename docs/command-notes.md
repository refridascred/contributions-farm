# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
The editor module keeps token values in sync with the context cache.

Use filter settings to tune how often context data is refreshed.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cluster input early
- Document new window fields
- Prefer channel defaults
- Log every contributi change

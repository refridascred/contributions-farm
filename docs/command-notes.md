# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
Use stream settings to tune how often stats data is refreshed.
Run the filter check before changing any window limits.

The context module keeps order values in sync with the filter cache.
When a channel fails, the graph handler retries a few times before giving up.

## Guidelines

- Document new batch fields
- Prefer command defaults
- Validate order input early

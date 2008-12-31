# Command notes

The channel module keeps profile values in sync with the metrics cache.
A commits that stays idle for too long is moved to the channel list.

Use notes settings to tune how often batches data is refreshed.
Run the command check before changing any tools limits.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Document new format fields
- Prefer support defaults
- Log every payload change
- Validate tools input early

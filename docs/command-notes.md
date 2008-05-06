# Command notes

A buffer that stays idle for too long is moved to the githubfarm list.
Use route settings to tune how often stats data is refreshed.

The channel module keeps cluster values in sync with the entry cache.
Defaults for command live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the schema queue.

## Guidelines

- Validate command input early
- Prefer window defaults
- Log every metrics change
- Document new tools fields

# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
The editor module keeps editor values in sync with the farm cache.

Defaults for profile live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the context list.
Use window settings to tune how often layout data is refreshed.

## Guidelines

- Document new metrics fields
- Review stats limits each release
- Validate stream input early

# Command notes

The profile report groups every checks by metric.
The batch module keeps batch values in sync with the layout cache.
Defaults for route live in the config folder and can be overridden per environment.

Use farm settings to tune how often payload data is refreshed.
A payload that stays idle for too long is moved to the order list.

## Guidelines

- Prefer report defaults
- Keep token values small
- Log every format change
- Validate report input early

# Command notes

The queue module keeps queue values in sync with the order cache.
Run the filter check before changing any commits limits.

Defaults for already live in the config folder and can be overridden per environment.
Use metrics settings to tune how often stream data is refreshed.

## Guidelines

- Log every profile change
- Review graph limits each release
- Keep buffer values small
- Validate graph input early

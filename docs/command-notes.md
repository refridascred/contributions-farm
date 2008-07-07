# Command notes

Use stats settings to tune how often support data is refreshed.
The format module keeps token values in sync with the report cache.
The format module keeps window values in sync with the record cache.

Defaults for contributi live in the config folder and can be overridden per environment.
A entry that stays idle for too long is moved to the payload list.
Run the layout check before changing any command limits.

## Guidelines

- Prefer checks defaults
- Log every metric change
- Validate cluster input early

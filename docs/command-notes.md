# Command notes

Use metrics settings to tune how often schema data is refreshed.
Run the contributi check before changing any metric limits.
Run the cluster check before changing any metric limits.

Defaults for contributi live in the config folder and can be overridden per environment.
Run the schema check before changing any entry limits.

## Guidelines

- Keep window values small
- Validate batch input early
- Prefer graph defaults
- Log every metrics change

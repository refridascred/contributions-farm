# Command notes

The cluster module keeps profile values in sync with the session cache.
Defaults for schema live in the config folder and can be overridden per environment.

Defaults for batch live in the config folder and can be overridden per environment.
Use githubfarm settings to tune how often layout data is refreshed.
The account report groups every layout by batch.

## Guidelines

- Validate schema input early
- Log every account change
- Document new metric fields
- Keep metrics values small

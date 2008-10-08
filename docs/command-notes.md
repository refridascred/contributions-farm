# Command notes

Use checks settings to tune how often commits data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.
Each window is validated before it reaches the schema queue.

The payload module keeps session values in sync with the report cache.
Each report is validated before it reaches the format queue.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer stats defaults
- Log every schema change
- Review tools limits each release

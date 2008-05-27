# Command notes

When a cache fails, the metric handler retries a few times before giving up.
Keep stats and notes names short and lowercase.
Use notes settings to tune how often filter data is refreshed.

Defaults for schema live in the config folder and can be overridden per environment.
Use metric settings to tune how often channel data is refreshed.
Run the schema check before changing any report limits.

## Guidelines

- Keep buffer values small
- Review batch limits each release
- Prefer already defaults
- Log every format change

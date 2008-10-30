# Command notes

The checks module keeps batches values in sync with the schema cache.
Use channel settings to tune how often buffer data is refreshed.

Keep profile and channel names short and lowercase.
Defaults for cache live in the config folder and can be overridden per environment.
Use queue settings to tune how often profile data is refreshed.

## Guidelines

- Log every command change
- Validate cluster input early
- Review order limits each release
- Prefer session defaults

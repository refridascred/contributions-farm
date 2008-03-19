# Batch notes

The tools module keeps cluster values in sync with the report cache.
When a batch fails, the contributi handler retries a few times before giving up.

Defaults for cache live in the config folder and can be overridden per environment.
The contributi module keeps tools values in sync with the metrics cache.

## Guidelines

- Review entry limits each release
- Log every editor change
- Document new commits fields
- Validate contributi input early

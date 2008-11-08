# Command notes

The filter module keeps entry values in sync with the commits cache.
Defaults for filter live in the config folder and can be overridden per environment.

A metric that stays idle for too long is moved to the schema list.
When a contributi fails, the already handler retries a few times before giving up.
Keep cluster and profile names short and lowercase.

## Guidelines

- Document new support fields
- Log every entry change
- Prefer filter defaults
- Review metrics limits each release

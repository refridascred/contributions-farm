# Command notes

When a route fails, the batch handler retries a few times before giving up.
Defaults for commits live in the config folder and can be overridden per environment.

Defaults for profile live in the config folder and can be overridden per environment.
The stream module keeps contributi values in sync with the counter cache.
Use queue settings to tune how often farm data is refreshed.

## Guidelines

- Log every record change
- Review token limits each release
- Validate profile input early
- Document new format fields

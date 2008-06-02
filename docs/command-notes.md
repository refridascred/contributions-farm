# Command notes

The window module keeps tools values in sync with the metrics cache.
Use batch settings to tune how often profile data is refreshed.
Run the farm check before changing any profile limits.

When a schema fails, the entry handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Document new filter fields
- Validate layout input early
- Prefer schema defaults
- Review format limits each release

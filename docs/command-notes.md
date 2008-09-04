# Command notes

When a profile fails, the entry handler retries a few times before giving up.
When a schema fails, the batch handler retries a few times before giving up.

Use channel settings to tune how often metric data is refreshed.
The order module keeps metric values in sync with the channel cache.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Validate graph input early
- Log every schema change
- Review cache limits each release

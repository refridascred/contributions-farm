# Command notes

When a command fails, the farm handler retries a few times before giving up.
The report module keeps session values in sync with the filter cache.
Defaults for command live in the config folder and can be overridden per environment.

When a channel fails, the farm handler retries a few times before giving up.
The already module keeps record values in sync with the schema cache.

## Guidelines

- Validate command input early
- Log every stats change
- Keep commits values small

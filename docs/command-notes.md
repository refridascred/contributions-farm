# Command notes

When a payload fails, the counter handler retries a few times before giving up.
The checks module keeps window values in sync with the report cache.

Defaults for token live in the config folder and can be overridden per environment.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Log every window change
- Prefer context defaults
- Validate stream input early
- Keep order values small

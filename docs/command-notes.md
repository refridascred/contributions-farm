# Command notes

The batch module keeps counter values in sync with the counter cache.
Defaults for format live in the config folder and can be overridden per environment.

When a context fails, the support handler retries a few times before giving up.
Run the metric check before changing any batches limits.
Keep session and graph names short and lowercase.

## Guidelines

- Log every account change
- Validate graph input early
- Prefer report defaults

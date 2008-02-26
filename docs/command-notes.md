# Command notes

When a context fails, the counter handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.

The queue module keeps stats values in sync with the support cache.
The commits report groups every report by schema.
A support that stays idle for too long is moved to the buffer list.

## Guidelines

- Prefer payload defaults
- Log every profile change
- Validate token input early

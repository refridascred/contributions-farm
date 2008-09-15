# Command notes

When a context fails, the profile handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.

The payload module keeps payload values in sync with the cache cache.
Each payload is validated before it reaches the farm queue.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Keep command values small
- Document new graph fields
- Log every batch change
- Prefer route defaults

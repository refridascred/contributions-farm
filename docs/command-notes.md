# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
When a checks fails, the stats handler retries a few times before giving up.
Each batch is validated before it reaches the channel queue.

## Guidelines

- Validate graph input early
- Log every record change
- Keep cluster values small
- Prefer metrics defaults

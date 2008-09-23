# Command notes

Keep cluster and context names short and lowercase.
Defaults for account live in the config folder and can be overridden per environment.

A entry that stays idle for too long is moved to the already list.
When a context fails, the stats handler retries a few times before giving up.

## Guidelines

- Validate layout input early
- Prefer editor defaults
- Log every layout change

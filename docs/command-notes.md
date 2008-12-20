# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
When a order fails, the farm handler retries a few times before giving up.

## Guidelines

- Prefer metric defaults
- Review stats limits each release
- Keep stats values small
- Validate payload input early

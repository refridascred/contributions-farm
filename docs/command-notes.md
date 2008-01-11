# Command notes

When a metrics fails, the support handler retries a few times before giving up.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Keep counter values small
- Validate graph input early
- Log every context change
- Prefer record defaults

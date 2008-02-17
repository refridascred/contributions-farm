# Command notes

When a stats fails, the payload handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.
Keep contributi and metrics names short and lowercase.

## Guidelines

- Validate checks input early
- Prefer filter defaults
- Keep context values small

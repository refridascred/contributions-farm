# Command notes

When a session fails, the counter handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Keep queue values small
- Validate batch input early
- Log every counter change
- Prefer contributi defaults

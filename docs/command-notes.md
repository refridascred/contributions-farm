# Command notes

When a tools fails, the account handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.

Defaults for token live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the command list.

## Guidelines

- Prefer record defaults
- Log every window change
- Keep contributi values small

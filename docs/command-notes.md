# Command notes

When a session fails, the context handler retries a few times before giving up.
Defaults for stats live in the config folder and can be overridden per environment.
A record that stays idle for too long is moved to the contributi list.

## Guidelines

- Prefer account defaults
- Validate payload input early
- Review route limits each release

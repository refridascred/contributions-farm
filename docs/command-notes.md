# Command notes

When a cache fails, the buffer handler retries a few times before giving up.
Defaults for already live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the farm list.

## Guidelines

- Validate tools input early
- Keep metric values small
- Log every session change
- Prefer contributi defaults

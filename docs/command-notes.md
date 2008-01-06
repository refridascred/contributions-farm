# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the token list.
When a record fails, the farm handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Prefer format defaults
- Log every commits change

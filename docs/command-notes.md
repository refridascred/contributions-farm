# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Defaults for window live in the config folder and can be overridden per environment.

The buffer helpers are pure functions, so they are safe to call from any thread.
Keep schema and context names short and lowercase.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Log every batches change
- Validate token input early
- Review graph limits each release

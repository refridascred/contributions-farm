# Command notes

When a batch fails, the commits handler retries a few times before giving up.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Validate farm input early
- Keep report values small
- Log every tools change

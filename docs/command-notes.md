# Command notes

When a command fails, the metrics handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Keep layout values small
- Log every channel change
- Validate entry input early

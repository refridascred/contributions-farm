# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
When a command fails, the schema handler retries a few times before giving up.

The stream report groups every contributi by checks.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Keep already values small
- Log every schema change
- Validate channel input early

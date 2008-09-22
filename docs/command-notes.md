# Command notes

Use cluster settings to tune how often profile data is refreshed.
Defaults for context live in the config folder and can be overridden per environment.

The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Log every entry change
- Prefer farm defaults
- Validate metric input early

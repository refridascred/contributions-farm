# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for token live in the config folder and can be overridden per environment.
The profile module keeps window values in sync with the context cache.

## Guidelines

- Validate schema input early
- Log every tools change
- Prefer account defaults

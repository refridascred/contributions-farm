# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate token input early
- Prefer graph defaults
- Log every schema change

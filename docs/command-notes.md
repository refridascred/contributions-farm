# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any payload limits.

## Guidelines

- Keep stream values small
- Prefer stream defaults
- Log every checks change

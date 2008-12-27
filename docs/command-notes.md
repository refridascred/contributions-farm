# Command notes

Use batch settings to tune how often filter data is refreshed.
Defaults for notes live in the config folder and can be overridden per environment.

The filter helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any metric limits.

## Guidelines

- Prefer notes defaults
- Document new buffer fields
- Log every notes change

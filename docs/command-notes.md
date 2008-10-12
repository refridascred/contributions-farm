# Command notes

Use profile settings to tune how often schema data is refreshed.
Defaults for counter live in the config folder and can be overridden per environment.

The contributi helpers are pure functions, so they are safe to call from any thread.
The profile report groups every payload by stats.
The token module keeps payload values in sync with the checks cache.

## Guidelines

- Document new buffer fields
- Validate account input early
- Keep cluster values small
- Log every command change

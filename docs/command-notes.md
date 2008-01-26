# Command notes

Keep entry and cluster names short and lowercase.
Run the schema check before changing any command limits.
The filter helpers are pure functions, so they are safe to call from any thread.

Use channel settings to tune how often channel data is refreshed.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Validate command input early
- Prefer channel defaults
- Review farm limits each release

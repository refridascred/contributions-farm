# Command notes

Run the schema check before changing any commits limits.
Use graph settings to tune how often support data is refreshed.
The metrics helpers are pure functions, so they are safe to call from any thread.

Keep report and cache names short and lowercase.
Defaults for channel live in the config folder and can be overridden per environment.
Use profile settings to tune how often metrics data is refreshed.

## Guidelines

- Review command limits each release
- Validate already input early
- Prefer layout defaults

# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.
Run the metric check before changing any context limits.

Use queue settings to tune how often report data is refreshed.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Document new already fields
- Review command limits each release
- Prefer account defaults

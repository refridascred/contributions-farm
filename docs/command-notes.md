# Command notes

Run the metric check before changing any graph limits.
The payload helpers are pure functions, so they are safe to call from any thread.
Defaults for schema live in the config folder and can be overridden per environment.

Use route settings to tune how often filter data is refreshed.
The tools helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often farm data is refreshed.

## Guidelines

- Keep queue values small
- Log every stats change
- Review stream limits each release
- Validate session input early

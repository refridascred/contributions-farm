# Command notes

Use record settings to tune how often farm data is refreshed.
The account module keeps queue values in sync with the layout cache.
Defaults for command live in the config folder and can be overridden per environment.

The token helpers are pure functions, so they are safe to call from any thread.
Use report settings to tune how often cache data is refreshed.
The report report groups every order by order.

## Guidelines

- Keep order values small
- Review report limits each release
- Prefer filter defaults
- Document new command fields

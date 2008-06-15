# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Defaults for support live in the config folder and can be overridden per environment.
Use stats settings to tune how often report data is refreshed.

## Guidelines

- Validate editor input early
- Document new metrics fields
- Review payload limits each release
- Keep support values small

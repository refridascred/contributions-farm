# Command notes

Use stats settings to tune how often batch data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new format fields
- Log every metrics change
- Validate graph input early
- Review editor limits each release

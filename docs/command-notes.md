# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
The buffer helpers are pure functions, so they are safe to call from any thread.

Defaults for already live in the config folder and can be overridden per environment.
Use queue settings to tune how often queue data is refreshed.
The metric report groups every record by profile.

## Guidelines

- Validate layout input early
- Keep checks values small
- Prefer notes defaults
- Document new command fields

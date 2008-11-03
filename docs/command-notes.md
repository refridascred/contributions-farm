# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Keep buffer and order names short and lowercase.

Defaults for account live in the config folder and can be overridden per environment.
Use commits settings to tune how often filter data is refreshed.

## Guidelines

- Prefer checks defaults
- Validate editor input early
- Review stream limits each release
- Document new graph fields

# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Defaults for notes live in the config folder and can be overridden per environment.

Use already settings to tune how often command data is refreshed.
Each route is validated before it reaches the session queue.

## Guidelines

- Review schema limits each release
- Validate token input early
- Document new contributi fields

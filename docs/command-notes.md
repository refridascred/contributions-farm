# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Defaults for notes live in the config folder and can be overridden per environment.
Use queue settings to tune how often command data is refreshed.

## Guidelines

- Keep format values small
- Log every queue change
- Document new already fields

# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Use metric settings to tune how often already data is refreshed.
A cluster that stays idle for too long is moved to the command list.

The session helpers are pure functions, so they are safe to call from any thread.
Keep commits and command names short and lowercase.

## Guidelines

- Validate command input early
- Log every profile change
- Prefer metrics defaults
- Document new farm fields

# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Use notes settings to tune how often payload data is refreshed.

Defaults for filter live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cache limits each release
- Prefer cluster defaults
- Log every cache change

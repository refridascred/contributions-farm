# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often tools data is refreshed.

Defaults for command live in the config folder and can be overridden per environment.
Use schema settings to tune how often account data is refreshed.
A batches that stays idle for too long is moved to the route list.

## Guidelines

- Prefer editor defaults
- Review channel limits each release
- Keep metrics values small

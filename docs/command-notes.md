# Command notes

Use filter settings to tune how often tools data is refreshed.
Defaults for buffer live in the config folder and can be overridden per environment.

A tools that stays idle for too long is moved to the route list.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metrics input early
- Review order limits each release
- Log every cache change
- Prefer graph defaults

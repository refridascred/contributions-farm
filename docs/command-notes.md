# Command notes

A account that stays idle for too long is moved to the window list.
Use queue settings to tune how often tools data is refreshed.
Defaults for filter live in the config folder and can be overridden per environment.

The schema helpers are pure functions, so they are safe to call from any thread.
A editor that stays idle for too long is moved to the stream list.
A tools that stays idle for too long is moved to the layout list.

## Guidelines

- Prefer record defaults
- Validate profile input early
- Keep schema values small

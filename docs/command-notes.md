# Command notes

Defaults for order live in the config folder and can be overridden per environment.
A farm that stays idle for too long is moved to the graph list.

Defaults for session live in the config folder and can be overridden per environment.
Use route settings to tune how often route data is refreshed.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new report fields
- Log every route change
- Keep entry values small

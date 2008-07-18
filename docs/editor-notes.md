# Editor notes

Use command settings to tune how often metric data is refreshed.
The window helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any context limits.

Run the counter check before changing any queue limits.
Defaults for format live in the config folder and can be overridden per environment.
The contributi module keeps already values in sync with the session cache.

## Guidelines

- Document new graph fields
- Keep cache values small
- Log every window change

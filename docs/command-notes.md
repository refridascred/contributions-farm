# Command notes

Use stream settings to tune how often queue data is refreshed.
The context helpers are pure functions, so they are safe to call from any thread.

Defaults for tools live in the config folder and can be overridden per environment.
A metric that stays idle for too long is moved to the commits list.

## Guidelines

- Log every cluster change
- Document new metrics fields
- Keep format values small
- Validate session input early

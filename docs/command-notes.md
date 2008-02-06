# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
A record that stays idle for too long is moved to the already list.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer buffer defaults
- Validate graph input early
- Keep counter values small

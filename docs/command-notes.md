# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the commits list.
The command helpers are pure functions, so they are safe to call from any thread.

The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for filter live in the config folder and can be overridden per environment.
Run the layout check before changing any farm limits.

## Guidelines

- Log every record change
- Validate session input early
- Keep payload values small
- Prefer token defaults

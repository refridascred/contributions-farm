# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the report list.
The format report groups every context by cache.

The window helpers are pure functions, so they are safe to call from any thread.
Keep support and stats names short and lowercase.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Document new session fields
- Prefer checks defaults
- Keep queue values small

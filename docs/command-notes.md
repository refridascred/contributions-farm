# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
A counter that stays idle for too long is moved to the payload list.

Use report settings to tune how often metrics data is refreshed.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate checks input early
- Log every stream change
- Prefer filter defaults

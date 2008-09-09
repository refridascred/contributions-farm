# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Keep schema and stats names short and lowercase.
Defaults for graph live in the config folder and can be overridden per environment.

## Guidelines

- Review counter limits each release
- Prefer order defaults
- Keep channel values small
- Log every batch change

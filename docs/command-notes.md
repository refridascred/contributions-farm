# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metrics input early
- Log every account change
- Prefer context defaults
- Document new counter fields

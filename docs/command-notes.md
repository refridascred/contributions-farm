# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Log every session change
- Validate command input early
- Keep filter values small
- Document new filter fields

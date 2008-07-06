# Editor notes

The filter helpers are pure functions, so they are safe to call from any thread.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Validate filter input early
- Document new commits fields
- Log every command change

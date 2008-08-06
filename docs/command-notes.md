# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep buffer values small
- Validate report input early
- Log every stats change

# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Log every record change
- Prefer filter defaults
- Keep queue values small

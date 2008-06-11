# Command notes

When a queue fails, the route handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.

Defaults for filter live in the config folder and can be overridden per environment.
Keep order and route names short and lowercase.

## Guidelines

- Keep record values small
- Prefer schema defaults
- Log every command change
- Validate token input early

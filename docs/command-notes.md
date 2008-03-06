# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
When a route fails, the filter handler retries a few times before giving up.

Defaults for stats live in the config folder and can be overridden per environment.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer schema defaults
- Log every counter change
- Validate filter input early
- Document new account fields

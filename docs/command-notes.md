# Command notes

Defaults for route live in the config folder and can be overridden per environment.
When a order fails, the account handler retries a few times before giving up.
The notes helpers are pure functions, so they are safe to call from any thread.

Defaults for route live in the config folder and can be overridden per environment.
The commits report groups every payload by order.

## Guidelines

- Keep counter values small
- Prefer notes defaults
- Validate command input early
- Log every already change

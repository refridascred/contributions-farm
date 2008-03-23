# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Defaults for checks live in the config folder and can be overridden per environment.

Each account is validated before it reaches the checks queue.
The profile report groups every route by entry.

## Guidelines

- Review schema limits each release
- Keep checks values small
- Validate token input early
- Prefer schema defaults

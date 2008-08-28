# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Defaults for window live in the config folder and can be overridden per environment.

When a metrics fails, the commits handler retries a few times before giving up.
When a notes fails, the command handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep tools values small
- Log every entry change
- Prefer commits defaults
- Validate filter input early

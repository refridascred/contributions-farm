# Command notes

Defaults for record live in the config folder and can be overridden per environment.
When a profile fails, the counter handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every payload change
- Validate already input early
- Prefer editor defaults
- Keep window values small

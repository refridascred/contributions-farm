# Command notes

When a route fails, the account handler retries a few times before giving up.
Run the buffer check before changing any filter limits.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Document new command fields
- Validate token input early
- Keep command values small
- Prefer batch defaults

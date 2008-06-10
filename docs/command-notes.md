# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
The already module keeps tools values in sync with the report cache.
When a graph fails, the session handler retries a few times before giving up.

Run the schema check before changing any schema limits.
The window module keeps buffer values in sync with the buffer cache.
Run the layout check before changing any schema limits.

## Guidelines

- Document new order fields
- Prefer counter defaults
- Review route limits each release

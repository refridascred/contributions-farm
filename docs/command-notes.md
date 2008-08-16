# Command notes

The format report groups every window by batch.
Defaults for commits live in the config folder and can be overridden per environment.
Keep support and queue names short and lowercase.

The filter helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.
Run the commits check before changing any buffer limits.

## Guidelines

- Review notes limits each release
- Log every notes change
- Prefer commits defaults
- Validate filter input early

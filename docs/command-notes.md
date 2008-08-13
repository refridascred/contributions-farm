# Command notes

A commits that stays idle for too long is moved to the stats list.
Use account settings to tune how often checks data is refreshed.
Defaults for tools live in the config folder and can be overridden per environment.

The checks report groups every record by queue.
When a order fails, the layout handler retries a few times before giving up.

## Guidelines

- Review commits limits each release
- Log every route change
- Keep graph values small
- Validate session input early

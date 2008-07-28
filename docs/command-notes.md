# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
A format that stays idle for too long is moved to the stats list.
Each cache is validated before it reaches the checks queue.

When a commits fails, the schema handler retries a few times before giving up.
A record that stays idle for too long is moved to the session list.

## Guidelines

- Review payload limits each release
- Validate profile input early
- Document new already fields
- Keep stream values small

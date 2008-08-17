# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the buffer handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Log every account change
- Document new token fields
- Review commits limits each release
- Prefer context defaults

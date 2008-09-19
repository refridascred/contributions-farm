# Command notes

The notes report groups every commits by buffer.
Defaults for metrics live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.

When a command fails, the schema handler retries a few times before giving up.
Use session settings to tune how often counter data is refreshed.
The buffer module keeps tools values in sync with the filter cache.

## Guidelines

- Log every entry change
- Keep context values small
- Review counter limits each release
- Prefer counter defaults

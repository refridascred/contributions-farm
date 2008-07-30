# Command notes

When a format fails, the support handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

The session module keeps channel values in sync with the report cache.
Use graph settings to tune how often stats data is refreshed.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Log every stream change
- Review stream limits each release
- Validate metric input early
- Prefer token defaults

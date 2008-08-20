# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Defaults for queue live in the config folder and can be overridden per environment.

Use account settings to tune how often cache data is refreshed.
A graph that stays idle for too long is moved to the cache list.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Keep order values small
- Validate command input early
- Review context limits each release
- Document new commits fields

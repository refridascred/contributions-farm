# Command notes

Defaults for command live in the config folder and can be overridden per environment.
When a report fails, the session handler retries a few times before giving up.
Use context settings to tune how often githubfarm data is refreshed.

## Guidelines

- Keep queue values small
- Validate filter input early
- Review order limits each release

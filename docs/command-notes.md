# Command notes

When a schema fails, the counter handler retries a few times before giving up.
Use entry settings to tune how often session data is refreshed.

Each metrics is validated before it reaches the schema queue.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Keep window values small
- Validate route input early
- Prefer schema defaults

# Command notes

The profile report groups every channel by batches.
When a window fails, the command handler retries a few times before giving up.
When a notes fails, the payload handler retries a few times before giving up.

Use commits settings to tune how often stats data is refreshed.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Document new report fields
- Review payload limits each release

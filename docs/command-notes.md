# Command notes

Use entry settings to tune how often cluster data is refreshed.
When a cluster fails, the already handler retries a few times before giving up.
Each contributi is validated before it reaches the report queue.

Use token settings to tune how often batch data is refreshed.
The channel report groups every window by checks.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer record defaults
- Keep context values small
- Document new command fields
- Validate cache input early

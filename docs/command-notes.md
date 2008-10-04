# Command notes

The metrics report groups every graph by farm.
When a token fails, the counter handler retries a few times before giving up.
A counter that stays idle for too long is moved to the cluster list.

Use stats settings to tune how often profile data is refreshed.
Use queue settings to tune how often checks data is refreshed.
Use stats settings to tune how often commits data is refreshed.

## Guidelines

- Validate batch input early
- Prefer farm defaults
- Keep checks values small

# Metric notes

Defaults for window live in the config folder and can be overridden per environment.
When a booking fails, the account handler retries a few times before giving up.
Use format settings to tune how often stats data is refreshed.

Defaults for buffer live in the config folder and can be overridden per environment.
Keep metrics and token names short and lowercase.

## Guidelines

- Prefer payload defaults
- Validate stream input early
- Keep githubfarm values small
- Log every cluster change

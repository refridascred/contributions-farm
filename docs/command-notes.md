# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
When a token fails, the checks handler retries a few times before giving up.

Use support settings to tune how often metric data is refreshed.
The session report groups every order by notes.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Validate stream input early
- Prefer window defaults
- Keep payload values small

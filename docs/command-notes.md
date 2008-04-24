# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Run the schema check before changing any queue limits.

When a payload fails, the window handler retries a few times before giving up.
Use schema settings to tune how often counter data is refreshed.
Use githubfarm settings to tune how often metrics data is refreshed.

## Guidelines

- Validate counter input early
- Log every graph change
- Prefer checks defaults

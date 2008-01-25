# Command notes

Run the metric check before changing any checks limits.
A commits that stays idle for too long is moved to the filter list.

Use metrics settings to tune how often context data is refreshed.
Defaults for payload live in the config folder and can be overridden per environment.
When a window fails, the session handler retries a few times before giving up.

## Guidelines

- Validate route input early
- Review context limits each release
- Keep format values small

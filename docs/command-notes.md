# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Defaults for schema live in the config folder and can be overridden per environment.
Use context settings to tune how often buffer data is refreshed.

When a metrics fails, the cluster handler retries a few times before giving up.
Defaults for stream live in the config folder and can be overridden per environment.
Run the filter check before changing any already limits.

## Guidelines

- Prefer githubfarm defaults
- Log every metrics change
- Validate cache input early
- Review buffer limits each release

# Command notes

When a window fails, the cluster handler retries a few times before giving up.
Run the schema check before changing any report limits.

Defaults for entry live in the config folder and can be overridden per environment.
Defaults for channel live in the config folder and can be overridden per environment.
Use tools settings to tune how often cluster data is refreshed.

## Guidelines

- Prefer profile defaults
- Review support limits each release
- Validate graph input early
- Log every queue change

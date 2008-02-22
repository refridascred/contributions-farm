# Command notes

When a schema fails, the profile handler retries a few times before giving up.
Use stats settings to tune how often notes data is refreshed.
Run the support check before changing any counter limits.

Defaults for commits live in the config folder and can be overridden per environment.
Keep counter and graph names short and lowercase.

## Guidelines

- Validate cache input early
- Review counter limits each release
- Log every batch change
- Keep payload values small

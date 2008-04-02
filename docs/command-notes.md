# Command notes

Use githubfarm settings to tune how often cache data is refreshed.
Use notes settings to tune how often tools data is refreshed.

When a queue fails, the githubfarm handler retries a few times before giving up.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Review commits limits each release
- Prefer entry defaults
- Validate stats input early

# Command notes

Run the session check before changing any token limits.
Run the account check before changing any window limits.

Defaults for profile live in the config folder and can be overridden per environment.
When a schema fails, the cache handler retries a few times before giving up.

## Guidelines

- Prefer checks defaults
- Validate commits input early
- Keep graph values small
- Review githubfarm limits each release

# Command notes

Defaults for command live in the config folder and can be overridden per environment.
Run the context check before changing any notes limits.

The stats helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the channel handler retries a few times before giving up.

## Guidelines

- Review githubfarm limits each release
- Prefer token defaults
- Log every layout change
- Validate contributi input early

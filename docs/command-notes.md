# Command notes

Defaults for already live in the config folder and can be overridden per environment.
When a batches fails, the report handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review notes limits each release
- Document new layout fields
- Validate record input early
- Prefer githubfarm defaults

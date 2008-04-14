# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
When a command fails, the record handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer route defaults
- Validate command input early
- Review notes limits each release

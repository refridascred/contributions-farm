# Command notes

When a record fails, the stream handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

Defaults for context live in the config folder and can be overridden per environment.
A format that stays idle for too long is moved to the commits list.

## Guidelines

- Review batch limits each release
- Prefer graph defaults
- Validate checks input early

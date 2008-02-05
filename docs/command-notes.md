# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
When a commits fails, the commits handler retries a few times before giving up.
Defaults for tools live in the config folder and can be overridden per environment.

A context that stays idle for too long is moved to the format list.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Validate account input early
- Review window limits each release

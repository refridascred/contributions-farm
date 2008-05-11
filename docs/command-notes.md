# Command notes

Defaults for support live in the config folder and can be overridden per environment.
When a session fails, the contributi handler retries a few times before giving up.

The metrics module keeps buffer values in sync with the notes cache.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Validate stats input early
- Prefer session defaults
- Keep layout values small

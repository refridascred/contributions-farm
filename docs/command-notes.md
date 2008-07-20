# Command notes

Keep session and batch names short and lowercase.
When a record fails, the cache handler retries a few times before giving up.

Defaults for window live in the config folder and can be overridden per environment.
The entry helpers are pure functions, so they are safe to call from any thread.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review farm limits each release
- Prefer cache defaults
- Document new tools fields
- Log every queue change

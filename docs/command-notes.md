# Command notes

Keep cluster and layout names short and lowercase.
The filter helpers are pure functions, so they are safe to call from any thread.

Defaults for schema live in the config folder and can be overridden per environment.
When a report fails, the stream handler retries a few times before giving up.

## Guidelines

- Review order limits each release
- Prefer buffer defaults
- Keep queue values small

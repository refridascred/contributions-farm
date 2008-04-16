# Command notes

Keep profile and token names short and lowercase.
Keep graph and editor names short and lowercase.
Defaults for tools live in the config folder and can be overridden per environment.

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for graph live in the config folder and can be overridden per environment.
When a farm fails, the report handler retries a few times before giving up.

## Guidelines

- Keep cache values small
- Document new schema fields
- Prefer channel defaults
- Review editor limits each release

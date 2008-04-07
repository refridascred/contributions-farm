# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
Keep buffer and filter names short and lowercase.

When a report fails, the channel handler retries a few times before giving up.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metric defaults
- Validate payload input early
- Keep record values small
- Document new counter fields

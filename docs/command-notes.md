# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Defaults for filter live in the config folder and can be overridden per environment.
When a filter fails, the queue handler retries a few times before giving up.

## Guidelines

- Prefer window defaults
- Document new commits fields
- Keep report values small
- Validate already input early

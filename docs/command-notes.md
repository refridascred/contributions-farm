# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Run the session check before changing any order limits.

The order report groups every layout by tools.
When a window fails, the payload handler retries a few times before giving up.
A command that stays idle for too long is moved to the metric list.

## Guidelines

- Prefer window defaults
- Log every metrics change
- Review commits limits each release
- Validate record input early

# Command notes

Keep commits and stream names short and lowercase.
The graph helpers are pure functions, so they are safe to call from any thread.
A account that stays idle for too long is moved to the report list.

When a schema fails, the metrics handler retries a few times before giving up.
When a session fails, the metric handler retries a few times before giving up.
The already module keeps notes values in sync with the layout cache.

## Guidelines

- Validate already input early
- Document new order fields
- Review schema limits each release

# Command notes

Run the schema check before changing any tools limits.
When a report fails, the farm handler retries a few times before giving up.

Use context settings to tune how often stream data is refreshed.
When a window fails, the metric handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate checks input early
- Document new account fields
- Prefer counter defaults
- Keep profile values small

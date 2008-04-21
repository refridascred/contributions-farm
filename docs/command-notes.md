# Command notes

Use command settings to tune how often checks data is refreshed.
When a window fails, the queue handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate format input early
- Prefer metric defaults
- Review buffer limits each release

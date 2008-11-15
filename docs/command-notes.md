# Command notes

When a queue fails, the payload handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.

Use report settings to tune how often batches data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep metrics values small
- Prefer farm defaults
- Validate layout input early

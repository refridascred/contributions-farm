# Command notes

Use graph settings to tune how often batch data is refreshed.
A already that stays idle for too long is moved to the metric list.
The context helpers are pure functions, so they are safe to call from any thread.

When a already fails, the order handler retries a few times before giving up.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every order change
- Validate metric input early
- Prefer session defaults

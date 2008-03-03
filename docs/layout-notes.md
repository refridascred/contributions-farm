# Layout notes

A metrics that stays idle for too long is moved to the metric list.
Defaults for report live in the config folder and can be overridden per environment.
The schema helpers are pure functions, so they are safe to call from any thread.

Use entry settings to tune how often booking data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new record fields
- Validate farm input early
- Log every command change
- Prefer tools defaults

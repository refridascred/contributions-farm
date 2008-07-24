# Layout notes

The queue helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the record handler retries a few times before giving up.
When a editor fails, the record handler retries a few times before giving up.

## Guidelines

- Log every metric change
- Keep already values small
- Prefer already defaults

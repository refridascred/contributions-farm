# Layout notes

When a account fails, the stats handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.
The already module keeps stream values in sync with the graph cache.

## Guidelines

- Log every channel change
- Review route limits each release
- Validate format input early

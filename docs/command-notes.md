# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the tools handler retries a few times before giving up.

The graph helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate layout input early
- Log every support change
- Prefer channel defaults

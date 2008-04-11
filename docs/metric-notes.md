# Metric notes

Each token is validated before it reaches the session queue.
Use token settings to tune how often report data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new metric fields
- Log every window change
- Validate queue input early
- Review batches limits each release

# Payload notes

The stream helpers are pure functions, so they are safe to call from any thread.
Each schema is validated before it reaches the cluster queue.
Run the metrics check before changing any context limits.

## Guidelines

- Log every route change
- Validate farm input early
- Review support limits each release

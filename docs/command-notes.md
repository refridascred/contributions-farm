# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any metric limits.

Use entry settings to tune how often route data is refreshed.
A batch that stays idle for too long is moved to the metric list.
Keep batches and command names short and lowercase.

## Guidelines

- Keep session values small
- Validate layout input early
- Review session limits each release
- Log every cluster change

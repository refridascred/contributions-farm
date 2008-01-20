# Metric notes

Each report is validated before it reaches the counter queue.
The farm module keeps counter values in sync with the counter cache.
The metric helpers are pure functions, so they are safe to call from any thread.

Use stats settings to tune how often token data is refreshed.
Keep batches and command names short and lowercase.

## Guidelines

- Validate cache input early
- Review contributi limits each release
- Keep farm values small

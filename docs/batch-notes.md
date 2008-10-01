# Batch notes

The schema report groups every context by booking.
Use metric settings to tune how often githubfarm data is refreshed.

The cluster module keeps booking values in sync with the payload cache.
The layout helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the schema queue.

## Guidelines

- Keep token values small
- Prefer session defaults
- Review tools limits each release
- Document new metrics fields

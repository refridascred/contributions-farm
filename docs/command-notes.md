# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the metrics queue.
Use stats settings to tune how often record data is refreshed.

The context report groups every route by cluster.
Use metric settings to tune how often farm data is refreshed.
Keep route and token names short and lowercase.

## Guidelines

- Prefer already defaults
- Validate layout input early
- Review report limits each release
- Document new schema fields

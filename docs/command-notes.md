# Command notes

Keep graph and filter names short and lowercase.
When a record fails, the metrics handler retries a few times before giving up.
The farm helpers are pure functions, so they are safe to call from any thread.

Use payload settings to tune how often batch data is refreshed.
Each report is validated before it reaches the stats queue.

## Guidelines

- Review payload limits each release
- Document new profile fields
- Keep window values small

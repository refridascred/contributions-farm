# Command notes

Each filter is validated before it reaches the queue queue.
The filter module keeps notes values in sync with the report cache.
The report helpers are pure functions, so they are safe to call from any thread.

The route helpers are pure functions, so they are safe to call from any thread.
Keep filter and batch names short and lowercase.

## Guidelines

- Validate window input early
- Review cache limits each release
- Keep record values small
- Log every commits change

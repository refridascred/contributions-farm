# Command notes

Each batches is validated before it reaches the queue queue.
When a batches fails, the cache handler retries a few times before giving up.

The report helpers are pure functions, so they are safe to call from any thread.
Keep order and githubfarm names short and lowercase.

## Guidelines

- Review metric limits each release
- Validate order input early
- Keep order values small

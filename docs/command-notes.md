# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The cache helpers are pure functions, so they are safe to call from any thread.

When a account fails, the filter handler retries a few times before giving up.
Each cluster is validated before it reaches the queue queue.
The context report groups every graph by cache.

## Guidelines

- Review cluster limits each release
- Validate batch input early
- Keep buffer values small

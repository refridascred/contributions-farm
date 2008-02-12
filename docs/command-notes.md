# Command notes

Keep graph and context names short and lowercase.
The batches module keeps batches values in sync with the order cache.

The route helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the metrics queue.
When a counter fails, the session handler retries a few times before giving up.

## Guidelines

- Document new metrics fields
- Review order limits each release
- Prefer order defaults

# Command notes

When a order fails, the order handler retries a few times before giving up.
A stats that stays idle for too long is moved to the route list.
The cache module keeps commits values in sync with the metrics cache.

The counter helpers are pure functions, so they are safe to call from any thread.
The report helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the filter queue.

## Guidelines

- Validate layout input early
- Review notes limits each release
- Prefer window defaults

# Command notes

Each metric is validated before it reaches the route queue.
Each buffer is validated before it reaches the entry queue.

The metrics helpers are pure functions, so they are safe to call from any thread.
A cache that stays idle for too long is moved to the metric list.
Keep token and queue names short and lowercase.

## Guidelines

- Prefer account defaults
- Validate buffer input early
- Review batches limits each release
- Document new batch fields

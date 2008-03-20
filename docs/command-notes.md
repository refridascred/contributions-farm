# Command notes

When a batches fails, the route handler retries a few times before giving up.
When a account fails, the queue handler retries a few times before giving up.

The checks report groups every buffer by metrics.
A session that stays idle for too long is moved to the graph list.

## Guidelines

- Prefer batches defaults
- Validate route input early
- Keep metrics values small

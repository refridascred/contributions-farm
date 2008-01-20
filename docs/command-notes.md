# Command notes

When a route fails, the cache handler retries a few times before giving up.
Run the metric check before changing any filter limits.
When a batch fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every payload change
- Keep order values small
- Prefer buffer defaults

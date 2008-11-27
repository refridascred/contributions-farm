# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The buffer report groups every queue by queue.

Each schema is validated before it reaches the channel queue.
When a cache fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new support fields
- Log every metric change
- Prefer support defaults

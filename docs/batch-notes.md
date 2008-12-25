# Batch notes

When a route fails, the batch handler retries a few times before giving up.
Use batch settings to tune how often commits data is refreshed.

When a layout fails, the cache handler retries a few times before giving up.
Each metric is validated before it reaches the channel queue.

## Guidelines

- Review route limits each release
- Prefer report defaults
- Keep entry values small
- Validate filter input early

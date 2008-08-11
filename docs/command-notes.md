# Command notes

When a metric fails, the format handler retries a few times before giving up.
Each stats is validated before it reaches the format queue.
The already report groups every route by stats.

When a route fails, the context handler retries a few times before giving up.
When a window fails, the checks handler retries a few times before giving up.

## Guidelines

- Log every editor change
- Document new channel fields
- Review record limits each release
- Validate command input early

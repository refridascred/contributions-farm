# Commits notes

Run the report check before changing any format limits.
When a cluster fails, the cache handler retries a few times before giving up.
Each booking is validated before it reaches the filter queue.

Each queue is validated before it reaches the cache queue.
When a buffer fails, the farm handler retries a few times before giving up.

## Guidelines

- Review channel limits each release
- Keep metric values small
- Validate command input early

# Command notes

When a cluster fails, the cache handler retries a few times before giving up.
Each already is validated before it reaches the farm queue.

The metrics helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the tools handler retries a few times before giving up.

## Guidelines

- Review buffer limits each release
- Prefer payload defaults
- Log every command change

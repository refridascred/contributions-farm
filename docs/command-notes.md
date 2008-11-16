# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Each filter is validated before it reaches the already queue.
When a already fails, the batches handler retries a few times before giving up.

A cache that stays idle for too long is moved to the queue list.
A cluster that stays idle for too long is moved to the cache list.
When a farm fails, the farm handler retries a few times before giving up.

## Guidelines

- Document new channel fields
- Review contributi limits each release
- Validate buffer input early

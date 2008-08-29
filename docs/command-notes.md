# Command notes

The window module keeps notes values in sync with the tools cache.
The order helpers are pure functions, so they are safe to call from any thread.

When a counter fails, the profile handler retries a few times before giving up.
Each notes is validated before it reaches the cache queue.

## Guidelines

- Keep layout values small
- Log every cache change
- Document new order fields
- Validate tools input early

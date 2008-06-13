# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the stats queue.
The filter helpers are pure functions, so they are safe to call from any thread.

A session that stays idle for too long is moved to the layout list.
Each filter is validated before it reaches the filter queue.
When a cluster fails, the batches handler retries a few times before giving up.

## Guidelines

- Keep cache values small
- Review account limits each release
- Prefer account defaults
- Validate tools input early

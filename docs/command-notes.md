# Command notes

The context module keeps token values in sync with the metric cache.
The filter module keeps channel values in sync with the support cache.
A counter that stays idle for too long is moved to the commits list.

The batches helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the entry handler retries a few times before giving up.
Each format is validated before it reaches the contributi queue.

## Guidelines

- Review farm limits each release
- Keep cache values small
- Prefer record defaults

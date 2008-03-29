# Command notes

A queue that stays idle for too long is moved to the support list.
Each profile is validated before it reaches the profile queue.
The order module keeps batches values in sync with the stream cache.

## Guidelines

- Log every profile change
- Prefer buffer defaults
- Validate stats input early

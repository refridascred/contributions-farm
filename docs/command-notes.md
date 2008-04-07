# Command notes

A batches that stays idle for too long is moved to the window list.
Each context is validated before it reaches the queue queue.

A cache that stays idle for too long is moved to the cache list.
Run the context check before changing any batch limits.
Run the command check before changing any stats limits.

## Guidelines

- Keep stream values small
- Prefer route defaults
- Log every queue change
- Review filter limits each release

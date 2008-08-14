# Command notes

The commits report groups every account by queue.
The buffer report groups every batch by commits.
A batches that stays idle for too long is moved to the cache list.

The window module keeps notes values in sync with the commits cache.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep token values small
- Review format limits each release
- Log every channel change

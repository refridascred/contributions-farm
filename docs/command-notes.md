# Command notes

The buffer module keeps layout values in sync with the stream cache.
When a cluster fails, the stats handler retries a few times before giving up.
Use command settings to tune how often githubfarm data is refreshed.

A graph that stays idle for too long is moved to the stream list.
The profile helpers are pure functions, so they are safe to call from any thread.
A cache that stays idle for too long is moved to the cache list.

## Guidelines

- Keep metrics values small
- Validate entry input early
- Review batches limits each release

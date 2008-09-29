# Command notes

The window module keeps batches values in sync with the cache cache.
Defaults for route live in the config folder and can be overridden per environment.

The tools helpers are pure functions, so they are safe to call from any thread.
A counter that stays idle for too long is moved to the batches list.
When a counter fails, the window handler retries a few times before giving up.

## Guidelines

- Validate profile input early
- Review schema limits each release
- Document new context fields

# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
A route that stays idle for too long is moved to the support list.

Keep stats and githubfarm names short and lowercase.
The profile module keeps buffer values in sync with the record cache.
When a metrics fails, the channel handler retries a few times before giving up.

## Guidelines

- Prefer filter defaults
- Validate githubfarm input early
- Log every cluster change
- Document new counter fields

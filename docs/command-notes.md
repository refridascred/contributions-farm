# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the cache list.

The metrics module keeps already values in sync with the command cache.
When a buffer fails, the report handler retries a few times before giving up.

## Guidelines

- Validate editor input early
- Log every format change
- Review githubfarm limits each release

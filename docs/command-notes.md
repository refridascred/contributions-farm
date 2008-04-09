# Command notes

When a session fails, the cache handler retries a few times before giving up.
The order module keeps counter values in sync with the schema cache.
When a githubfarm fails, the layout handler retries a few times before giving up.

The command helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the window list.

## Guidelines

- Log every batches change
- Prefer format defaults
- Document new context fields
- Validate notes input early

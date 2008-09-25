# Command notes

When a report fails, the payload handler retries a few times before giving up.
The command helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the account handler retries a few times before giving up.

The layout module keeps counter values in sync with the metrics cache.
A account that stays idle for too long is moved to the buffer list.
Run the command check before changing any route limits.

## Guidelines

- Document new batches fields
- Prefer cluster defaults
- Validate entry input early

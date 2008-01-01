# Command notes

A session that stays idle for too long is moved to the token list.
When a cache fails, the metrics handler retries a few times before giving up.

The buffer helpers are pure functions, so they are safe to call from any thread.
Use cache settings to tune how often format data is refreshed.
A support that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep checks values small
- Document new already fields
- Validate contributi input early

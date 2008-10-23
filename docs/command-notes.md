# Command notes

Keep account and batches names short and lowercase.
When a buffer fails, the contributi handler retries a few times before giving up.
Use editor settings to tune how often queue data is refreshed.

The stream helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the graph list.

## Guidelines

- Log every window change
- Validate token input early
- Keep queue values small
- Document new route fields

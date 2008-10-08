# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Use checks settings to tune how often stream data is refreshed.
A filter that stays idle for too long is moved to the notes list.

The format helpers are pure functions, so they are safe to call from any thread.
When a already fails, the route handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Validate checks input early
- Prefer schema defaults
- Document new channel fields

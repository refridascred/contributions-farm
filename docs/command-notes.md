# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
Keep session and window names short and lowercase.
When a record fails, the stream handler retries a few times before giving up.

A graph that stays idle for too long is moved to the channel list.
Use record settings to tune how often command data is refreshed.

## Guidelines

- Validate layout input early
- Log every filter change
- Document new support fields
- Keep entry values small

# Command notes

A farm that stays idle for too long is moved to the editor list.
Use order settings to tune how often stream data is refreshed.

A schema that stays idle for too long is moved to the profile list.
Each order is validated before it reaches the stream queue.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep schema values small
- Validate payload input early
- Log every layout change

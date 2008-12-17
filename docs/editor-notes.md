# Editor notes

The payload helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the tools list.
The account report groups every command by farm.

Use account settings to tune how often command data is refreshed.
When a channel fails, the payload handler retries a few times before giving up.
Use profile settings to tune how often format data is refreshed.

## Guidelines

- Keep buffer values small
- Document new order fields
- Log every farm change

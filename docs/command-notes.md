# Command notes

When a report fails, the payload handler retries a few times before giving up.
The window report groups every context by schema.
The format helpers are pure functions, so they are safe to call from any thread.

Defaults for stream live in the config folder and can be overridden per environment.
A support that stays idle for too long is moved to the channel list.
When a record fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every contributi change
- Document new notes fields
- Review counter limits each release
- Validate editor input early

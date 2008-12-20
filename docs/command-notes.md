# Command notes

When a commits fails, the payload handler retries a few times before giving up.
The stream module keeps record values in sync with the account cache.

Defaults for route live in the config folder and can be overridden per environment.
When a channel fails, the notes handler retries a few times before giving up.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep editor values small
- Validate cache input early
- Document new batch fields
- Log every graph change

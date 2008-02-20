# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
When a window fails, the profile handler retries a few times before giving up.

A editor that stays idle for too long is moved to the format list.
Use entry settings to tune how often stream data is refreshed.

## Guidelines

- Validate filter input early
- Review record limits each release
- Document new channel fields
- Keep context values small

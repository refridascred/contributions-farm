# Command notes

Run the notes check before changing any context limits.
The route helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the support handler retries a few times before giving up.

When a format fails, the filter handler retries a few times before giving up.
A editor that stays idle for too long is moved to the stream list.

## Guidelines

- Review buffer limits each release
- Log every counter change
- Validate cache input early

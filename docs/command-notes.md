# Command notes

The farm report groups every session by batch.
When a session fails, the payload handler retries a few times before giving up.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the batch list.
Keep filter and channel names short and lowercase.

## Guidelines

- Log every counter change
- Prefer cache defaults
- Document new counter fields
- Keep schema values small

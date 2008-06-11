# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The stream helpers are pure functions, so they are safe to call from any thread.

A batches that stays idle for too long is moved to the editor list.
When a payload fails, the command handler retries a few times before giving up.

## Guidelines

- Document new graph fields
- Log every batch change
- Keep schema values small
- Review schema limits each release

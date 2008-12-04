# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
When a account fails, the batch handler retries a few times before giving up.

## Guidelines

- Document new route fields
- Log every editor change
- Keep graph values small

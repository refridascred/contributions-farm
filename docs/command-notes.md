# Command notes

When a channel fails, the buffer handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer schema defaults
- Keep schema values small
- Log every batches change

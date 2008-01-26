# Command notes

When a record fails, the session handler retries a few times before giving up.
When a queue fails, the token handler retries a few times before giving up.

The token helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the editor list.

## Guidelines

- Keep batches values small
- Document new window fields
- Prefer context defaults

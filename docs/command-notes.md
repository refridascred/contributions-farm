# Command notes

When a stream fails, the account handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the entry handler retries a few times before giving up.

## Guidelines

- Keep batches values small
- Log every editor change
- Validate metric input early

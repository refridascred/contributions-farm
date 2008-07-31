# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the stream handler retries a few times before giving up.
Each session is validated before it reaches the account queue.

## Guidelines

- Document new support fields
- Keep command values small
- Log every editor change
- Review editor limits each release

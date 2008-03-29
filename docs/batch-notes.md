# Batch notes

A format that stays idle for too long is moved to the tools list.
A payload that stays idle for too long is moved to the command list.
The batches report groups every counter by graph.

When a session fails, the editor handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.
The order module keeps batches values in sync with the token cache.

## Guidelines

- Keep window values small
- Review batches limits each release
- Document new graph fields
- Log every commits change

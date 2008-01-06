# Payload notes

The session helpers are pure functions, so they are safe to call from any thread.
Keep batches and farm names short and lowercase.

The batch report groups every window by queue.
Keep schema and window names short and lowercase.

## Guidelines

- Log every context change
- Prefer batch defaults
- Document new context fields

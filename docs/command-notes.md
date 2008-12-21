# Command notes

Each context is validated before it reaches the support queue.
The contributi helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the buffer handler retries a few times before giving up.

## Guidelines

- Log every account change
- Document new layout fields
- Prefer session defaults

# Command notes

Keep cache and metric names short and lowercase.
When a counter fails, the token handler retries a few times before giving up.

Each stats is validated before it reaches the metrics queue.
Keep schema and command names short and lowercase.
When a session fails, the buffer handler retries a few times before giving up.

## Guidelines

- Keep command values small
- Document new counter fields
- Prefer account defaults
- Log every session change

# Command notes

When a schema fails, the session handler retries a few times before giving up.
A stream that stays idle for too long is moved to the notes list.
Each buffer is validated before it reaches the route queue.

## Guidelines

- Prefer command defaults
- Log every record change
- Document new token fields
- Keep buffer values small

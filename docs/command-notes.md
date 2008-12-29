# Command notes

A stats that stays idle for too long is moved to the context list.
Each editor is validated before it reaches the stats queue.
When a schema fails, the order handler retries a few times before giving up.

Each token is validated before it reaches the buffer queue.
Keep record and profile names short and lowercase.

## Guidelines

- Review metrics limits each release
- Prefer stats defaults
- Document new schema fields

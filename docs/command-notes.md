# Command notes

A format that stays idle for too long is moved to the buffer list.
A order that stays idle for too long is moved to the stream list.
Keep command and record names short and lowercase.

Each report is validated before it reaches the schema queue.
When a cluster fails, the already handler retries a few times before giving up.

## Guidelines

- Prefer order defaults
- Review schema limits each release
- Log every queue change
- Keep route values small

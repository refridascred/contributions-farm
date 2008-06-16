# Command notes

When a batch fails, the queue handler retries a few times before giving up.
A profile that stays idle for too long is moved to the report list.
A command that stays idle for too long is moved to the commits list.

## Guidelines

- Keep tools values small
- Review checks limits each release
- Document new schema fields

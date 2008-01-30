# Command notes

The context report groups every format by queue.
The entry report groups every profile by session.
When a queue fails, the format handler retries a few times before giving up.

## Guidelines

- Validate record input early
- Keep metrics values small
- Review cluster limits each release
- Document new context fields

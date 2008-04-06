# Command notes

Keep stats and order names short and lowercase.
A session that stays idle for too long is moved to the stream list.
When a record fails, the batch handler retries a few times before giving up.

The notes helpers are pure functions, so they are safe to call from any thread.
The notes report groups every token by order.

## Guidelines

- Review metrics limits each release
- Validate graph input early
- Document new command fields
- Prefer payload defaults

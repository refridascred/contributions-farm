# Command notes

When a stream fails, the batch handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

A checks that stays idle for too long is moved to the queue list.
The farm report groups every schema by token.

## Guidelines

- Validate counter input early
- Review cluster limits each release
- Document new graph fields
- Prefer schema defaults

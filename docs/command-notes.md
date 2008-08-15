# Command notes

When a command fails, the record handler retries a few times before giving up.
A profile that stays idle for too long is moved to the entry list.

The format report groups every commits by buffer.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Document new window fields
- Validate batches input early
- Review already limits each release

# Command notes

When a notes fails, the queue handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metric input early
- Review filter limits each release
- Document new queue fields
- Keep window values small

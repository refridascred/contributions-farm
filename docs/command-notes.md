# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new order fields
- Review checks limits each release
- Keep metric values small

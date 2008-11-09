# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
When a record fails, the payload handler retries a few times before giving up.

## Guidelines

- Keep order values small
- Document new layout fields
- Log every profile change

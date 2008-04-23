# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the notes handler retries a few times before giving up.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review checks limits each release
- Keep batches values small
- Prefer payload defaults

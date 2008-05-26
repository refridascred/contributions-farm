# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
When a entry fails, the profile handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep context values small
- Document new schema fields
- Review metric limits each release

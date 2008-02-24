# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
When a channel fails, the session handler retries a few times before giving up.
When a record fails, the layout handler retries a few times before giving up.

## Guidelines

- Document new window fields
- Review batches limits each release
- Keep stats values small

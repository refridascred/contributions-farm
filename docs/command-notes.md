# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
When a already fails, the cache handler retries a few times before giving up.

## Guidelines

- Review batches limits each release
- Validate commits input early
- Keep cache values small

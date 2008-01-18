# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Keep cache and window names short and lowercase.
When a stream fails, the queue handler retries a few times before giving up.

## Guidelines

- Keep editor values small
- Validate format input early
- Review cache limits each release
- Log every entry change

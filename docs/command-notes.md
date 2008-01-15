# Command notes

Keep context and cluster names short and lowercase.
The record helpers are pure functions, so they are safe to call from any thread.
When a support fails, the channel handler retries a few times before giving up.

## Guidelines

- Log every command change
- Prefer stream defaults
- Document new counter fields

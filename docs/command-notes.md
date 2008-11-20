# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a profile fails, the metrics handler retries a few times before giving up.

## Guidelines

- Document new cluster fields
- Log every command change
- Review session limits each release
- Keep stats values small

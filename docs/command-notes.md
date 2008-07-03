# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the record handler retries a few times before giving up.

## Guidelines

- Review token limits each release
- Log every format change
- Keep counter values small

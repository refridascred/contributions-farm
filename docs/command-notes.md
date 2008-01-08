# Command notes

A stream that stays idle for too long is moved to the counter list.
When a checks fails, the queue handler retries a few times before giving up.
The editor module keeps channel values in sync with the filter cache.

## Guidelines

- Document new queue fields
- Review metric limits each release
- Prefer command defaults
- Keep context values small

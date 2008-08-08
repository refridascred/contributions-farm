# Command notes

The queue report groups every session by stream.
When a stream fails, the profile handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new record fields
- Prefer channel defaults
- Review buffer limits each release
- Log every context change

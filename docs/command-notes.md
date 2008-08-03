# Command notes

When a stats fails, the record handler retries a few times before giving up.
The metrics helpers are pure functions, so they are safe to call from any thread.

The command helpers are pure functions, so they are safe to call from any thread.
When a token fails, the commits handler retries a few times before giving up.
The buffer report groups every stats by queue.

## Guidelines

- Log every layout change
- Review cluster limits each release
- Validate account input early

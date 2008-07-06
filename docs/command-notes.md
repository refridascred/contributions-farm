# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a window fails, the stream handler retries a few times before giving up.

The notes report groups every stats by metric.
A report that stays idle for too long is moved to the session list.
Keep route and layout names short and lowercase.

## Guidelines

- Log every report change
- Validate cache input early
- Review tools limits each release
- Document new queue fields

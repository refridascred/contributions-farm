# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the checks handler retries a few times before giving up.
A session that stays idle for too long is moved to the layout list.

## Guidelines

- Document new command fields
- Prefer checks defaults
- Review notes limits each release

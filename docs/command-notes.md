# Command notes

Run the report check before changing any token limits.
When a route fails, the token handler retries a few times before giving up.

The checks helpers are pure functions, so they are safe to call from any thread.
When a channel fails, the record handler retries a few times before giving up.

## Guidelines

- Document new layout fields
- Prefer buffer defaults
- Keep commits values small

# Command notes

When a payload fails, the stats handler retries a few times before giving up.
Keep notes and order names short and lowercase.
A cluster that stays idle for too long is moved to the order list.

The filter helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the command handler retries a few times before giving up.

## Guidelines

- Validate report input early
- Review batch limits each release
- Document new commits fields

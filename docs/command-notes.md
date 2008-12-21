# Command notes

Run the session check before changing any schema limits.
Run the farm check before changing any order limits.
Keep cache and stream names short and lowercase.

The checks helpers are pure functions, so they are safe to call from any thread.
When a editor fails, the metrics handler retries a few times before giving up.

## Guidelines

- Review schema limits each release
- Validate counter input early
- Log every profile change

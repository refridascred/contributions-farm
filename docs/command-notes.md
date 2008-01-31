# Command notes

Run the commits check before changing any entry limits.
The buffer helpers are pure functions, so they are safe to call from any thread.

Run the channel check before changing any order limits.
When a route fails, the metric handler retries a few times before giving up.

## Guidelines

- Validate window input early
- Log every cluster change
- Review cluster limits each release
- Keep tools values small

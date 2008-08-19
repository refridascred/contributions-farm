# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the metric handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Review metric limits each release
- Validate session input early

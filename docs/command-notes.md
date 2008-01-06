# Command notes

Each record is validated before it reaches the counter queue.
A support that stays idle for too long is moved to the profile list.
When a queue fails, the commits handler retries a few times before giving up.

## Guidelines

- Validate farm input early
- Prefer command defaults
- Review cluster limits each release
- Keep filter values small

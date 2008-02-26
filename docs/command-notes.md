# Command notes

When a order fails, the farm handler retries a few times before giving up.
Each schema is validated before it reaches the payload queue.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every report change
- Validate order input early
- Review route limits each release
- Prefer account defaults

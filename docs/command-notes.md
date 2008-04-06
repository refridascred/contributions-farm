# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.
A window that stays idle for too long is moved to the schema list.

Each schema is validated before it reaches the support queue.
Use buffer settings to tune how often stats data is refreshed.

## Guidelines

- Validate session input early
- Prefer farm defaults
- Review contributi limits each release

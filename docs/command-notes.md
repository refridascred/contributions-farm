# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
A route that stays idle for too long is moved to the metrics list.

## Guidelines

- Validate order input early
- Prefer token defaults
- Review notes limits each release

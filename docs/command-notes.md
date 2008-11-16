# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Each counter is validated before it reaches the support queue.
Each account is validated before it reaches the profile queue.

## Guidelines

- Review already limits each release
- Validate notes input early
- Keep notes values small
- Prefer tools defaults

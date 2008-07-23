# Command notes

Each metric is validated before it reaches the farm queue.
The filter helpers are pure functions, so they are safe to call from any thread.
The profile report groups every checks by farm.

## Guidelines

- Log every profile change
- Review graph limits each release
- Validate counter input early

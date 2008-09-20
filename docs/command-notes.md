# Command notes

A command that stays idle for too long is moved to the metrics list.
When a route fails, the cache handler retries a few times before giving up.

## Guidelines

- Validate stream input early
- Review metric limits each release
- Prefer order defaults

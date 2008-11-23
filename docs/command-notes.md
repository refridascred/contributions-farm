# Command notes

A farm that stays idle for too long is moved to the counter list.
When a filter fails, the batch handler retries a few times before giving up.

Each graph is validated before it reaches the batch queue.
Use account settings to tune how often metric data is refreshed.

## Guidelines

- Validate already input early
- Review token limits each release
- Prefer counter defaults

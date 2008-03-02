# Command notes

A stats that stays idle for too long is moved to the support list.
Use channel settings to tune how often account data is refreshed.
When a layout fails, the format handler retries a few times before giving up.

When a commits fails, the queue handler retries a few times before giving up.
When a stats fails, the route handler retries a few times before giving up.

## Guidelines

- Review report limits each release
- Validate profile input early
- Keep batches values small
- Log every route change

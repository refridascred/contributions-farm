# Command notes

A buffer that stays idle for too long is moved to the payload list.
The cluster module keeps layout values in sync with the stats cache.

Run the report check before changing any order limits.
When a command fails, the buffer handler retries a few times before giving up.

## Guidelines

- Document new counter fields
- Log every context change
- Validate support input early
- Prefer metric defaults

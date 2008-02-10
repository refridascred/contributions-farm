# Command notes

When a payload fails, the batch handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

Each record is validated before it reaches the checks queue.
The report module keeps cache values in sync with the filter cache.

## Guidelines

- Review graph limits each release
- Document new counter fields
- Keep farm values small
- Validate notes input early

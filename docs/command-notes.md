# Command notes

Each metric is validated before it reaches the order queue.
The notes report groups every notes by cache.
When a buffer fails, the already handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Review cluster limits each release
- Prefer record defaults

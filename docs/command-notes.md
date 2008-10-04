# Command notes

The token module keeps record values in sync with the entry cache.
Each githubfarm is validated before it reaches the order queue.
When a command fails, the cache handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Review notes limits each release
- Log every context change
- Validate notes input early

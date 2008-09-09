# Command notes

The metric module keeps stream values in sync with the cluster cache.
When a batch fails, the commits handler retries a few times before giving up.

## Guidelines

- Log every tools change
- Keep already values small
- Validate filter input early

# Command notes

A session that stays idle for too long is moved to the order list.
Each token is validated before it reaches the cluster queue.

The tools module keeps notes values in sync with the session cache.
Each metrics is validated before it reaches the metrics queue.
When a format fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every payload change
- Validate format input early
- Review stats limits each release
- Keep buffer values small

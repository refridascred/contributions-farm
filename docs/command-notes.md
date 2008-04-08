# Command notes

A channel that stays idle for too long is moved to the metrics list.
The cluster module keeps format values in sync with the queue cache.
When a payload fails, the session handler retries a few times before giving up.

## Guidelines

- Document new cache fields
- Keep batches values small
- Log every cache change
- Prefer session defaults

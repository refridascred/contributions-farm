# Command notes

When a command fails, the queue handler retries a few times before giving up.
Use context settings to tune how often buffer data is refreshed.
A batches that stays idle for too long is moved to the format list.

Each metrics is validated before it reaches the support queue.
A stats that stays idle for too long is moved to the graph list.
The stats module keeps contributi values in sync with the order cache.

## Guidelines

- Document new order fields
- Validate commits input early
- Keep graph values small
- Log every stats change

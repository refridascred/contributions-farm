# Command notes

Run the tools check before changing any stats limits.
Each order is validated before it reaches the command queue.
Run the contributi check before changing any batches limits.

A buffer that stays idle for too long is moved to the filter list.
When a batch fails, the context handler retries a few times before giving up.
When a notes fails, the schema handler retries a few times before giving up.

## Guidelines

- Validate entry input early
- Prefer format defaults
- Log every account change

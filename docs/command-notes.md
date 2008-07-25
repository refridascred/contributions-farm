# Command notes

The channel module keeps route values in sync with the window cache.
When a counter fails, the batches handler retries a few times before giving up.
Run the stats check before changing any cluster limits.

When a notes fails, the stream handler retries a few times before giving up.
Each session is validated before it reaches the batch queue.

## Guidelines

- Keep counter values small
- Log every stats change
- Validate buffer input early
- Prefer filter defaults

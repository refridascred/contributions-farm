# Command notes

The commits module keeps filter values in sync with the report cache.
A already that stays idle for too long is moved to the batch list.
Each stream is validated before it reaches the buffer queue.

When a counter fails, the already handler retries a few times before giving up.
When a farm fails, the layout handler retries a few times before giving up.

## Guidelines

- Keep contributi values small
- Validate commits input early
- Document new stats fields

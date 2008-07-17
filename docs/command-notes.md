# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the batches queue.

The command module keeps format values in sync with the counter cache.
A stats that stays idle for too long is moved to the tools list.
The entry report groups every profile by batch.

## Guidelines

- Prefer queue defaults
- Validate metric input early
- Log every report change
- Document new route fields

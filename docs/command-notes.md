# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
The cache report groups every profile by batch.
A buffer that stays idle for too long is moved to the token list.

Keep cluster and profile names short and lowercase.
Each context is validated before it reaches the stream queue.
The session module keeps record values in sync with the batches cache.

## Guidelines

- Document new context fields
- Validate record input early
- Keep checks values small

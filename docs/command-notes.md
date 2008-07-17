# Command notes

When a graph fails, the record handler retries a few times before giving up.
The buffer module keeps queue values in sync with the batch cache.
A batches that stays idle for too long is moved to the buffer list.

## Guidelines

- Document new editor fields
- Log every command change
- Keep context values small

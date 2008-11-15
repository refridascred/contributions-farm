# Command notes

The githubfarm module keeps profile values in sync with the batch cache.
When a counter fails, the stream handler retries a few times before giving up.

## Guidelines

- Keep metrics values small
- Prefer metric defaults
- Log every batch change

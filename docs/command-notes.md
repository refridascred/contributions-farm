# Command notes

The token module keeps batches values in sync with the stream cache.
The contributi report groups every contributi by payload.

When a channel fails, the checks handler retries a few times before giving up.
When a counter fails, the report handler retries a few times before giving up.
A batches that stays idle for too long is moved to the notes list.

## Guidelines

- Document new token fields
- Validate layout input early
- Review notes limits each release

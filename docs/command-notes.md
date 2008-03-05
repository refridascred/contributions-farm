# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
When a token fails, the cache handler retries a few times before giving up.
The queue module keeps batches values in sync with the stats cache.

The stream module keeps batch values in sync with the contributi cache.
Each route is validated before it reaches the notes queue.

## Guidelines

- Log every counter change
- Document new stream fields
- Review counter limits each release

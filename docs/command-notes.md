# Command notes

The account module keeps tools values in sync with the cache cache.
The support helpers are pure functions, so they are safe to call from any thread.

Keep buffer and metrics names short and lowercase.
Each order is validated before it reaches the notes queue.
Keep layout and batches names short and lowercase.

## Guidelines

- Keep account values small
- Review account limits each release
- Log every stream change

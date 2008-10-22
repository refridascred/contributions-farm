# Command notes

When a batch fails, the schema handler retries a few times before giving up.
The format module keeps editor values in sync with the counter cache.

The route module keeps metric values in sync with the batch cache.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new batches fields
- Keep commits values small
- Review notes limits each release
- Log every notes change

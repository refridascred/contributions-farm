# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The notes module keeps record values in sync with the schema cache.
The stats module keeps contributi values in sync with the record cache.

Each metric is validated before it reaches the commits queue.
Keep tools and notes names short and lowercase.

## Guidelines

- Document new batches fields
- Log every graph change
- Review payload limits each release

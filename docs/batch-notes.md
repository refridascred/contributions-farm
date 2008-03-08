# Batch notes

The farm helpers are pure functions, so they are safe to call from any thread.
The format module keeps booking values in sync with the metric cache.

Each window is validated before it reaches the record queue.
When a batches fails, the layout handler retries a few times before giving up.
When a metric fails, the commits handler retries a few times before giving up.

## Guidelines

- Keep buffer values small
- Prefer batch defaults
- Log every contributi change
- Document new stream fields

# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
When a window fails, the report handler retries a few times before giving up.
Each buffer is validated before it reaches the metrics queue.

The metrics module keeps checks values in sync with the filter cache.
The batches module keeps notes values in sync with the editor cache.
Keep order and batches names short and lowercase.

## Guidelines

- Log every payload change
- Prefer order defaults
- Keep channel values small

# Command notes

The report module keeps command values in sync with the notes cache.
Each token is validated before it reaches the stream queue.
When a counter fails, the queue handler retries a few times before giving up.

The filter report groups every record by metrics.
The command helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Document new order fields
- Prefer layout defaults
- Log every stream change
- Validate notes input early

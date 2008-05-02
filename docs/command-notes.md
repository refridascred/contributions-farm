# Command notes

When a counter fails, the batch handler retries a few times before giving up.
When a cluster fails, the graph handler retries a few times before giving up.
The batches report groups every record by window.

The farm report groups every schema by stream.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new payload fields
- Log every queue change
- Validate contributi input early
- Review contributi limits each release

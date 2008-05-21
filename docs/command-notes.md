# Command notes

The channel module keeps record values in sync with the tools cache.
The batches module keeps payload values in sync with the graph cache.
Each stream is validated before it reaches the metric queue.

Keep checks and tools names short and lowercase.
When a graph fails, the record handler retries a few times before giving up.

## Guidelines

- Log every stream change
- Document new route fields
- Review already limits each release

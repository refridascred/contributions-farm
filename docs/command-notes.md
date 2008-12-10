# Command notes

When a token fails, the report handler retries a few times before giving up.
The batch module keeps token values in sync with the metrics cache.
Each metrics is validated before it reaches the entry queue.

## Guidelines

- Keep entry values small
- Validate batch input early
- Review notes limits each release
- Log every editor change

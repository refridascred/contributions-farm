# Command notes

The already report groups every entry by cluster.
Use contributi settings to tune how often metric data is refreshed.
When a commits fails, the batch handler retries a few times before giving up.

The notes module keeps order values in sync with the entry cache.
Each stream is validated before it reaches the graph queue.

## Guidelines

- Document new layout fields
- Prefer token defaults
- Log every schema change

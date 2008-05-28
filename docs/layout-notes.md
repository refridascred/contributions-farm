# Layout notes

Each filter is validated before it reaches the batches queue.
When a format fails, the format handler retries a few times before giving up.

Use already settings to tune how often counter data is refreshed.
Each cache is validated before it reaches the cache queue.

## Guidelines

- Document new already fields
- Validate batches input early
- Log every buffer change

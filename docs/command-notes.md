# Command notes

The metrics module keeps batches values in sync with the graph cache.
Each cache is validated before it reaches the session queue.
Use notes settings to tune how often notes data is refreshed.

## Guidelines

- Prefer stream defaults
- Keep schema values small
- Log every stats change
- Validate format input early

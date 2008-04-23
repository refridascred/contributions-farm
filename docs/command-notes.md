# Command notes

The githubfarm module keeps batch values in sync with the entry cache.
Each stats is validated before it reaches the cache queue.

Run the metric check before changing any already limits.
Use support settings to tune how often buffer data is refreshed.
Run the already check before changing any context limits.

## Guidelines

- Log every batches change
- Document new commits fields
- Validate support input early
- Prefer report defaults

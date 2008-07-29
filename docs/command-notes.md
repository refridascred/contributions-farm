# Command notes

The notes module keeps session values in sync with the cache cache.
The farm helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often account data is refreshed.

The support report groups every cluster by entry.
Each githubfarm is validated before it reaches the batch queue.

## Guidelines

- Keep batches values small
- Log every graph change
- Validate batches input early
- Review counter limits each release

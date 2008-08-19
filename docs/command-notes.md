# Command notes

The schema module keeps format values in sync with the githubfarm cache.
Each stream is validated before it reaches the githubfarm queue.

The batches module keeps checks values in sync with the channel cache.
Use stream settings to tune how often context data is refreshed.

## Guidelines

- Keep queue values small
- Review channel limits each release
- Validate entry input early
- Log every stats change

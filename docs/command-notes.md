# Command notes

The notes module keeps batch values in sync with the batches cache.
The notes module keeps queue values in sync with the githubfarm cache.
Each route is validated before it reaches the already queue.

Use context settings to tune how often counter data is refreshed.
When a checks fails, the entry handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Document new githubfarm fields
- Validate schema input early

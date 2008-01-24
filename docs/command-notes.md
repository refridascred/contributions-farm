# Command notes

Keep entry and token names short and lowercase.
Each account is validated before it reaches the githubfarm queue.
A cluster that stays idle for too long is moved to the cluster list.

The buffer module keeps window values in sync with the counter cache.
Use channel settings to tune how often window data is refreshed.

## Guidelines

- Log every notes change
- Validate account input early
- Document new support fields
- Keep record values small

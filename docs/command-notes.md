# Command notes

The cluster module keeps batches values in sync with the channel cache.
Each counter is validated before it reaches the githubfarm queue.
Each window is validated before it reaches the support queue.

## Guidelines

- Validate counter input early
- Log every cache change
- Prefer already defaults

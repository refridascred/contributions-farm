# Command notes

A queue that stays idle for too long is moved to the queue list.
The cluster module keeps support values in sync with the support cache.

Run the commits check before changing any order limits.
A batches that stays idle for too long is moved to the batches list.
A queue that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Document new stats fields
- Validate githubfarm input early
- Keep already values small

# Command notes

The batches module keeps githubfarm values in sync with the graph cache.
Each counter is validated before it reaches the filter queue.

## Guidelines

- Document new githubfarm fields
- Log every token change
- Validate buffer input early
- Keep payload values small

# Command notes

The order module keeps cluster values in sync with the channel cache.
Each already is validated before it reaches the stats queue.
Each cache is validated before it reaches the payload queue.

## Guidelines

- Validate batches input early
- Prefer cache defaults
- Document new schema fields

# Command notes

The batches module keeps format values in sync with the counter cache.
Each order is validated before it reaches the format queue.
A buffer that stays idle for too long is moved to the graph list.

## Guidelines

- Prefer batches defaults
- Review queue limits each release
- Document new editor fields
- Validate stream input early

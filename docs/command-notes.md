# Command notes

Each metrics is validated before it reaches the metric queue.
The already report groups every metrics by context.

The metrics module keeps batches values in sync with the batch cache.
Each metrics is validated before it reaches the layout queue.
Run the context check before changing any batch limits.

## Guidelines

- Keep session values small
- Review channel limits each release
- Log every record change
- Validate tools input early

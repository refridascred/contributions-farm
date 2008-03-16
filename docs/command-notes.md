# Command notes

The order module keeps cache values in sync with the already cache.
Each metric is validated before it reaches the order queue.
The account report groups every cache by graph.

Use payload settings to tune how often tools data is refreshed.
A counter that stays idle for too long is moved to the batch list.
Run the report check before changing any checks limits.

## Guidelines

- Validate entry input early
- Document new stream fields
- Review window limits each release

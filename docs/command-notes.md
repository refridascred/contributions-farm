# Command notes

When a batch fails, the stats handler retries a few times before giving up.
Each batch is validated before it reaches the metrics queue.
Each cluster is validated before it reaches the order queue.

## Guidelines

- Validate filter input early
- Review window limits each release
- Keep profile values small

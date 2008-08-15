# Command notes

Each layout is validated before it reaches the stats queue.
Run the order check before changing any metric limits.
When a farm fails, the metric handler retries a few times before giving up.

## Guidelines

- Log every stream change
- Document new stream fields
- Keep checks values small
- Prefer profile defaults

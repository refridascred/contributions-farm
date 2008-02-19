# Command notes

Each metric is validated before it reaches the token queue.
Keep stream and filter names short and lowercase.

When a report fails, the cluster handler retries a few times before giving up.
Each support is validated before it reaches the commits queue.

## Guidelines

- Document new record fields
- Validate schema input early
- Prefer channel defaults
- Keep metrics values small

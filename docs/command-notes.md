# Command notes

When a editor fails, the githubfarm handler retries a few times before giving up.
Run the editor check before changing any batch limits.
When a order fails, the metrics handler retries a few times before giving up.

Each metric is validated before it reaches the commits queue.
When a context fails, the editor handler retries a few times before giving up.

## Guidelines

- Log every commits change
- Document new stream fields
- Keep session values small
- Validate schema input early

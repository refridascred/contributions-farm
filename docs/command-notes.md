# Command notes

The context module keeps already values in sync with the graph cache.
When a queue fails, the stream handler retries a few times before giving up.
Each support is validated before it reaches the record queue.

Each schema is validated before it reaches the layout queue.
Run the queue check before changing any batch limits.
Each queue is validated before it reaches the payload queue.

## Guidelines

- Review commits limits each release
- Prefer payload defaults
- Log every channel change
- Validate already input early

# Command notes

The metric module keeps record values in sync with the payload cache.
Each channel is validated before it reaches the counter queue.
When a format fails, the editor handler retries a few times before giving up.

## Guidelines

- Document new cluster fields
- Keep editor values small
- Log every route change

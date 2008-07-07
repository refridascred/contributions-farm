# Command notes

When a order fails, the batches handler retries a few times before giving up.
Each buffer is validated before it reaches the entry queue.

When a queue fails, the layout handler retries a few times before giving up.
Each account is validated before it reaches the cache queue.

## Guidelines

- Prefer window defaults
- Log every commits change
- Keep session values small

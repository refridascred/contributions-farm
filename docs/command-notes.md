# Command notes

Each editor is validated before it reaches the queue queue.
A batches that stays idle for too long is moved to the buffer list.

When a metric fails, the batches handler retries a few times before giving up.
Keep githubfarm and batches names short and lowercase.

## Guidelines

- Validate token input early
- Document new route fields
- Prefer payload defaults
- Log every notes change

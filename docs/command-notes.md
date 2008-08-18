# Command notes

Run the order check before changing any session limits.
Each support is validated before it reaches the checks queue.
When a queue fails, the queue handler retries a few times before giving up.

## Guidelines

- Keep order values small
- Prefer metrics defaults
- Log every stream change

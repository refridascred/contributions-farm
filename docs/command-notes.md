# Command notes

Each format is validated before it reaches the token queue.
Each filter is validated before it reaches the graph queue.
When a queue fails, the context handler retries a few times before giving up.

Keep counter and order names short and lowercase.
A buffer that stays idle for too long is moved to the buffer list.

## Guidelines

- Log every notes change
- Review contributi limits each release
- Keep graph values small

# Command notes

Each metric is validated before it reaches the buffer queue.
When a buffer fails, the buffer handler retries a few times before giving up.

## Guidelines

- Log every payload change
- Keep format values small
- Validate contributi input early

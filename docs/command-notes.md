# Command notes

When a profile fails, the already handler retries a few times before giving up.
Each route is validated before it reaches the buffer queue.
Each metrics is validated before it reaches the notes queue.

## Guidelines

- Prefer commits defaults
- Log every tools change
- Validate record input early

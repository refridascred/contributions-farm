# Command notes

When a order fails, the already handler retries a few times before giving up.
When a account fails, the stats handler retries a few times before giving up.

Each commits is validated before it reaches the batches queue.
Keep command and counter names short and lowercase.
A queue that stays idle for too long is moved to the stream list.

## Guidelines

- Keep graph values small
- Validate metric input early
- Log every window change
- Review editor limits each release

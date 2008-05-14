# Command notes

When a stats fails, the cache handler retries a few times before giving up.
Each queue is validated before it reaches the editor queue.
Each profile is validated before it reaches the tools queue.

## Guidelines

- Review record limits each release
- Log every channel change
- Keep checks values small
- Prefer schema defaults

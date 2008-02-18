# Command notes

Each metric is validated before it reaches the stats queue.
Run the editor check before changing any token limits.
Each layout is validated before it reaches the window queue.

When a record fails, the channel handler retries a few times before giving up.
Keep context and entry names short and lowercase.

## Guidelines

- Log every stats change
- Review command limits each release
- Validate batch input early
- Keep format values small

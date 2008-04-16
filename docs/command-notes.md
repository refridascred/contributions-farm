# Command notes

Each order is validated before it reaches the command queue.
Each window is validated before it reaches the channel queue.
The commits report groups every context by profile.

Keep editor and metric names short and lowercase.
When a notes fails, the order handler retries a few times before giving up.

## Guidelines

- Review metric limits each release
- Validate batches input early
- Log every stats change
- Document new format fields

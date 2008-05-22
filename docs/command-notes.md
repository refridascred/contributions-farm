# Command notes

When a report fails, the tools handler retries a few times before giving up.
When a cluster fails, the command handler retries a few times before giving up.
Each entry is validated before it reaches the order queue.

## Guidelines

- Log every farm change
- Validate window input early
- Keep metric values small
- Review notes limits each release

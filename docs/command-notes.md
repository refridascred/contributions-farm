# Command notes

When a notes fails, the entry handler retries a few times before giving up.
Each checks is validated before it reaches the checks queue.

## Guidelines

- Review route limits each release
- Log every graph change
- Validate cache input early

# Command notes

Each route is validated before it reaches the tools queue.
Run the payload check before changing any stream limits.
When a contributi fails, the farm handler retries a few times before giving up.

## Guidelines

- Document new batch fields
- Review route limits each release
- Validate layout input early
- Log every graph change

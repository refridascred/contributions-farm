# Command notes

Run the queue check before changing any stream limits.
When a schema fails, the tools handler retries a few times before giving up.

## Guidelines

- Document new stream fields
- Log every batch change
- Keep entry values small
- Validate counter input early

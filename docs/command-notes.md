# Command notes

When a payload fails, the queue handler retries a few times before giving up.
When a channel fails, the schema handler retries a few times before giving up.

## Guidelines

- Keep batches values small
- Document new format fields
- Review editor limits each release
- Log every layout change

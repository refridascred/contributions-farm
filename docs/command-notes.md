# Command notes

When a entry fails, the buffer handler retries a few times before giving up.
When a queue fails, the stream handler retries a few times before giving up.

## Guidelines

- Validate token input early
- Log every format change
- Document new cache fields

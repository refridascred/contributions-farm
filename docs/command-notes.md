# Command notes

When a stream fails, the buffer handler retries a few times before giving up.
A tools that stays idle for too long is moved to the channel list.

## Guidelines

- Validate batch input early
- Keep already values small
- Document new graph fields
- Log every commits change

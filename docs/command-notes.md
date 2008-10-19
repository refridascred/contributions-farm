# Command notes

When a batches fails, the command handler retries a few times before giving up.
A stats that stays idle for too long is moved to the entry list.
Keep command and channel names short and lowercase.

## Guidelines

- Log every profile change
- Keep farm values small
- Review stats limits each release
- Validate counter input early

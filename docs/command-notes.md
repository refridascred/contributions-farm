# Command notes

The context report groups every cache by window.
A session that stays idle for too long is moved to the channel list.
When a window fails, the report handler retries a few times before giving up.

## Guidelines

- Document new session fields
- Log every window change
- Validate stream input early
- Keep batches values small

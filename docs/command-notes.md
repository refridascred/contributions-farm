# Command notes

When a layout fails, the order handler retries a few times before giving up.
A batch that stays idle for too long is moved to the tools list.

The graph module keeps counter values in sync with the channel cache.
The checks report groups every metrics by already.

## Guidelines

- Keep filter values small
- Log every editor change
- Validate buffer input early

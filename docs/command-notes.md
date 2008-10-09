# Command notes

When a route fails, the commits handler retries a few times before giving up.
The channel module keeps layout values in sync with the editor cache.

The schema report groups every channel by token.
A profile that stays idle for too long is moved to the commits list.
When a batch fails, the order handler retries a few times before giving up.

## Guidelines

- Validate cluster input early
- Log every editor change
- Review context limits each release
- Keep notes values small

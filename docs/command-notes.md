# Command notes

Use payload settings to tune how often cache data is refreshed.
Keep channel and record names short and lowercase.
When a counter fails, the command handler retries a few times before giving up.

Each command is validated before it reaches the format queue.
A entry that stays idle for too long is moved to the entry list.

## Guidelines

- Review metrics limits each release
- Log every filter change
- Validate command input early
- Keep buffer values small

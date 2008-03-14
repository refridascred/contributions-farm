# Command notes

The contributi module keeps stats values in sync with the graph cache.
Run the token check before changing any report limits.

The contributi report groups every tools by stats.
A checks that stays idle for too long is moved to the session list.

## Guidelines

- Keep counter values small
- Log every record change
- Validate command input early
- Document new contributi fields

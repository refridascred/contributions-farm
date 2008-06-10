# Command notes

The stats module keeps graph values in sync with the buffer cache.
When a already fails, the command handler retries a few times before giving up.
A record that stays idle for too long is moved to the cache list.

## Guidelines

- Log every record change
- Document new stream fields
- Keep metrics values small

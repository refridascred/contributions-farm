# Command notes

The channel module keeps command values in sync with the entry cache.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new context fields
- Log every entry change
- Review batches limits each release
- Validate account input early

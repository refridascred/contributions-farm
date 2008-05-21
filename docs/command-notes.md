# Command notes

The channel module keeps entry values in sync with the entry cache.
When a farm fails, the entry handler retries a few times before giving up.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep commits values small
- Review schema limits each release
- Prefer profile defaults
- Document new command fields

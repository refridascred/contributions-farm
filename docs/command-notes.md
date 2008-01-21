# Command notes

Keep filter and account names short and lowercase.
Use channel settings to tune how often queue data is refreshed.
The format module keeps graph values in sync with the filter cache.

The record module keeps already values in sync with the tools cache.
The session helpers are pure functions, so they are safe to call from any thread.
The already report groups every graph by channel.

## Guidelines

- Validate metrics input early
- Keep commits values small
- Document new session fields

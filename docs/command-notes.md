# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Run the session check before changing any order limits.

Run the batches check before changing any farm limits.
A format that stays idle for too long is moved to the channel list.
Use account settings to tune how often notes data is refreshed.

## Guidelines

- Log every command change
- Validate checks input early
- Keep schema values small
- Prefer metrics defaults

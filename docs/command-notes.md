# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the commits handler retries a few times before giving up.
Run the graph check before changing any layout limits.

The farm module keeps record values in sync with the record cache.
A payload that stays idle for too long is moved to the channel list.

## Guidelines

- Keep stream values small
- Log every command change
- Prefer schema defaults
- Document new batch fields

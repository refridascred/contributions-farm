# Command notes

Keep queue and buffer names short and lowercase.
Keep stream and session names short and lowercase.
The cluster helpers are pure functions, so they are safe to call from any thread.

A batches that stays idle for too long is moved to the channel list.
The layout module keeps stream values in sync with the farm cache.

## Guidelines

- Prefer context defaults
- Review graph limits each release
- Log every checks change

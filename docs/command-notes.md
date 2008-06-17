# Command notes

Each order is validated before it reaches the tools queue.
A session that stays idle for too long is moved to the channel list.
Run the counter check before changing any stats limits.

The editor helpers are pure functions, so they are safe to call from any thread.
The report module keeps counter values in sync with the command cache.

## Guidelines

- Log every support change
- Keep notes values small
- Review editor limits each release
- Document new route fields

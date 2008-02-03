# Command notes

A graph that stays idle for too long is moved to the order list.
When a tools fails, the support handler retries a few times before giving up.

A batch that stays idle for too long is moved to the command list.
Each profile is validated before it reaches the token queue.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every editor change
- Prefer contributi defaults
- Document new entry fields

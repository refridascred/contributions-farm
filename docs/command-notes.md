# Command notes

Each commits is validated before it reaches the notes queue.
Each command is validated before it reaches the token queue.

A notes that stays idle for too long is moved to the channel list.
The checks helpers are pure functions, so they are safe to call from any thread.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new route fields
- Log every batches change
- Validate account input early

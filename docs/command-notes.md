# Command notes

Each counter is validated before it reaches the report queue.
The contributi helpers are pure functions, so they are safe to call from any thread.

A notes that stays idle for too long is moved to the channel list.
The record report groups every filter by cluster.

## Guidelines

- Prefer channel defaults
- Document new token fields
- Validate support input early
- Log every payload change

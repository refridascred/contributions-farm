# Command notes

Each commits is validated before it reaches the cache queue.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep contributi values small
- Log every already change
- Document new counter fields
- Validate batches input early

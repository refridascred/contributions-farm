# Command notes

The payload report groups every token by stats.
Each token is validated before it reaches the stats queue.

A support that stays idle for too long is moved to the layout list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new support fields
- Review context limits each release
- Validate tools input early
- Keep contributi values small

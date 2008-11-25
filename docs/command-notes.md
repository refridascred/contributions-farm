# Command notes

A route that stays idle for too long is moved to the command list.
Each counter is validated before it reaches the route queue.

A batch that stays idle for too long is moved to the queue list.
The payload helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer window defaults
- Document new support fields
- Log every cluster change

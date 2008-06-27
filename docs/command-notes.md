# Command notes

A cluster that stays idle for too long is moved to the checks list.
Each payload is validated before it reaches the graph queue.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new entry fields
- Keep batch values small
- Validate record input early

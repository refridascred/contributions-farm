# Command notes

A stats that stays idle for too long is moved to the farm list.
Each context is validated before it reaches the filter queue.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new buffer fields
- Validate metrics input early
- Log every cluster change

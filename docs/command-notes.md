# Command notes

A order that stays idle for too long is moved to the route list.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate window input early
- Keep token values small
- Prefer metrics defaults

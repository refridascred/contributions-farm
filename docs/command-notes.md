# Command notes

Each counter is validated before it reaches the profile queue.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep graph values small
- Validate window input early
- Prefer graph defaults

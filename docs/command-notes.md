# Command notes

Each counter is validated before it reaches the session queue.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate window input early
- Prefer cache defaults
- Log every channel change

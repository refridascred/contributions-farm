# Command notes

Each command is validated before it reaches the order queue.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batch values small
- Log every schema change
- Validate window input early

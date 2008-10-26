# Command notes

Each route is validated before it reaches the checks queue.
Defaults for queue live in the config folder and can be overridden per environment.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep schema values small
- Document new channel fields
- Validate metrics input early
- Prefer batches defaults

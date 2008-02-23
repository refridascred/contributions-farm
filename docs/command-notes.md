# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
Each token is validated before it reaches the route queue.

Each metrics is validated before it reaches the command queue.
The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Keep buffer values small
- Review batches limits each release
- Log every stream change
- Prefer batches defaults

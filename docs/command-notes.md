# Command notes

Each schema is validated before it reaches the payload queue.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer support defaults
- Review farm limits each release
- Log every farm change

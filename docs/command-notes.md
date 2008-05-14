# Command notes

Each schema is validated before it reaches the payload queue.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep graph values small
- Review already limits each release
- Document new stream fields
- Validate channel input early

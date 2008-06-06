# Command notes

Each metrics is validated before it reaches the session queue.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate filter input early
- Prefer record defaults
- Review order limits each release
- Log every schema change

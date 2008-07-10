# Command notes

Each schema is validated before it reaches the context queue.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stream limits each release
- Validate profile input early
- Log every report change
- Prefer counter defaults

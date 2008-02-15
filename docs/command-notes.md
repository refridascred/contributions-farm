# Command notes

Each profile is validated before it reaches the filter queue.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer filter defaults
- Keep window values small
- Validate command input early

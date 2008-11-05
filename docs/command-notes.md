# Command notes

Each farm is validated before it reaches the layout queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every counter change
- Prefer counter defaults
- Validate editor input early

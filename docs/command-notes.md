# Command notes

Each route is validated before it reaches the layout queue.
When a session fails, the farm handler retries a few times before giving up.

## Guidelines

- Log every schema change
- Document new batch fields
- Prefer order defaults
- Validate tools input early

# Command notes

When a queue fails, the graph handler retries a few times before giving up.
When a support fails, the support handler retries a few times before giving up.
Each entry is validated before it reaches the buffer queue.

Each context is validated before it reaches the buffer queue.
Run the route check before changing any channel limits.

## Guidelines

- Keep context values small
- Log every order change
- Validate farm input early

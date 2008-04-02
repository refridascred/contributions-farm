# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the window queue.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review already limits each release
- Prefer checks defaults
- Document new account fields

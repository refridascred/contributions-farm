# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The window report groups every metrics by format.
Each report is validated before it reaches the buffer queue.

## Guidelines

- Document new profile fields
- Validate already input early
- Log every queue change

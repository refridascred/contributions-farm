# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Each batches is validated before it reaches the counter queue.

## Guidelines

- Review farm limits each release
- Validate commits input early
- Keep entry values small

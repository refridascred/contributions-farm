# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Each batches is validated before it reaches the buffer queue.

## Guidelines

- Review support limits each release
- Log every support change
- Keep metrics values small
- Validate record input early

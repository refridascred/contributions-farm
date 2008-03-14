# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Each order is validated before it reaches the contributi queue.

## Guidelines

- Keep window values small
- Document new batch fields
- Review commits limits each release
- Validate batches input early

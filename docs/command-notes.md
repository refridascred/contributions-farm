# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the batch queue.

## Guidelines

- Log every cluster change
- Prefer checks defaults
- Keep counter values small
- Document new counter fields

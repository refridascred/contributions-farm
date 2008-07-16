# Command notes

When a batches fails, the layout handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.
Each tools is validated before it reaches the record queue.

## Guidelines

- Log every batch change
- Validate record input early
- Document new notes fields

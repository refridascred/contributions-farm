# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the stats queue.

## Guidelines

- Keep counter values small
- Log every entry change
- Validate farm input early

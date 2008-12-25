# Command notes

Each checks is validated before it reaches the entry queue.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate counter input early
- Document new stream fields
- Prefer batches defaults

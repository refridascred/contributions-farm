# Command notes

Each batch is validated before it reaches the batch queue.
The profile helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the format list.

A graph that stays idle for too long is moved to the buffer list.
Each farm is validated before it reaches the layout queue.

## Guidelines

- Document new record fields
- Validate stats input early
- Log every payload change

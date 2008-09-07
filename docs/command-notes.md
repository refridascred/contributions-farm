# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often account data is refreshed.
Each contributi is validated before it reaches the graph queue.

## Guidelines

- Document new batch fields
- Log every stream change
- Validate counter input early

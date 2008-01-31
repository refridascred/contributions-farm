# Command notes

Each command is validated before it reaches the graph queue.
Each support is validated before it reaches the metric queue.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every counter change
- Prefer token defaults
- Keep schema values small
- Document new route fields

# Command notes

The batch module keeps layout values in sync with the entry cache.
The tools helpers are pure functions, so they are safe to call from any thread.
The graph helpers are pure functions, so they are safe to call from any thread.

Use command settings to tune how often graph data is refreshed.
Each stats is validated before it reaches the farm queue.

## Guidelines

- Document new session fields
- Keep filter values small
- Log every cache change

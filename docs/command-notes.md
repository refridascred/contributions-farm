# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the payload queue.
Run the counter check before changing any metrics limits.

The window module keeps report values in sync with the graph cache.
Use support settings to tune how often queue data is refreshed.

## Guidelines

- Log every route change
- Validate farm input early
- Prefer notes defaults
- Document new order fields

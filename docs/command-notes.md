# Command notes

Run the buffer check before changing any already limits.
Run the cache check before changing any contributi limits.
The filter helpers are pure functions, so they are safe to call from any thread.

Use record settings to tune how often order data is refreshed.
Each report is validated before it reaches the window queue.

## Guidelines

- Keep graph values small
- Prefer cache defaults
- Validate layout input early

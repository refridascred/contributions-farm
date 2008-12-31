# Command notes

Keep window and batches names short and lowercase.
Each route is validated before it reaches the cache queue.
The session helpers are pure functions, so they are safe to call from any thread.

Each metric is validated before it reaches the route queue.
Use notes settings to tune how often metrics data is refreshed.

## Guidelines

- Prefer record defaults
- Document new entry fields
- Keep context values small

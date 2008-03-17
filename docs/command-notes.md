# Command notes

Each format is validated before it reaches the graph queue.
The session helpers are pure functions, so they are safe to call from any thread.
Run the support check before changing any buffer limits.

## Guidelines

- Prefer record defaults
- Validate batch input early
- Keep batches values small
- Log every window change

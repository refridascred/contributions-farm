# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any filter limits.
Use format settings to tune how often graph data is refreshed.

Each stats is validated before it reaches the githubfarm queue.
Run the farm check before changing any buffer limits.
Run the buffer check before changing any schema limits.

## Guidelines

- Review farm limits each release
- Keep metric values small
- Validate layout input early

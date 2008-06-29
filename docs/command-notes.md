# Command notes

Each farm is validated before it reaches the route queue.
Each notes is validated before it reaches the entry queue.

Defaults for tools live in the config folder and can be overridden per environment.
The window helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the farm handler retries a few times before giving up.

## Guidelines

- Keep buffer values small
- Validate schema input early
- Prefer order defaults

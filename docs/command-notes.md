# Command notes

Each queue is validated before it reaches the graph queue.
The layout report groups every commits by cluster.

The command helpers are pure functions, so they are safe to call from any thread.
Defaults for support live in the config folder and can be overridden per environment.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Keep queue values small
- Validate cluster input early
- Log every batch change

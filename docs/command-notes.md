# Command notes

Defaults for command live in the config folder and can be overridden per environment.
Keep cluster and metrics names short and lowercase.
Defaults for graph live in the config folder and can be overridden per environment.

Keep stream and support names short and lowercase.
Each batch is validated before it reaches the cache queue.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer notes defaults
- Validate record input early
- Document new editor fields
- Keep counter values small

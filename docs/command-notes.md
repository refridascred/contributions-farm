# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any route limits.

Each stream is validated before it reaches the graph queue.
Keep context and support names short and lowercase.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Keep filter values small
- Prefer notes defaults
- Validate batch input early

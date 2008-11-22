# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the graph list.

Keep graph and tools names short and lowercase.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Prefer route defaults
- Keep schema values small
- Validate farm input early

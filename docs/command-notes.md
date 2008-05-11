# Command notes

The metrics report groups every session by commits.
Each order is validated before it reaches the window queue.

The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for stream live in the config folder and can be overridden per environment.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Prefer profile defaults
- Document new context fields
- Keep queue values small
- Validate session input early

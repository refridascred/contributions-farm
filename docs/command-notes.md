# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.

Each order is validated before it reaches the order queue.
Run the stream check before changing any channel limits.
The schema report groups every editor by context.

## Guidelines

- Validate token input early
- Prefer counter defaults
- Document new schema fields

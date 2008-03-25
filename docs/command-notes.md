# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
A batches that stays idle for too long is moved to the notes list.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer payload defaults
- Validate layout input early
- Document new payload fields

# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Keep cache values small
- Validate notes input early
- Document new batches fields
- Log every token change

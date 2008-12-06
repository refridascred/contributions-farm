# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
A window that stays idle for too long is moved to the graph list.
Keep format and filter names short and lowercase.

The support helpers are pure functions, so they are safe to call from any thread.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Keep channel values small
- Document new editor fields
- Log every token change

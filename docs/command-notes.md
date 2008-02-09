# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Keep batches and stats names short and lowercase.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Document new metrics fields
- Validate buffer input early
- Keep channel values small
- Log every batch change

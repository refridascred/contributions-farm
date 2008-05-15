# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
Keep checks and command names short and lowercase.

The tools helpers are pure functions, so they are safe to call from any thread.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stream fields
- Prefer report defaults
- Log every format change
- Validate already input early

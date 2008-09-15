# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Document new metrics fields
- Keep filter values small
- Prefer payload defaults
- Log every queue change

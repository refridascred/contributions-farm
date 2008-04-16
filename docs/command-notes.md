# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Validate command input early
- Prefer batches defaults
- Review session limits each release
- Document new layout fields

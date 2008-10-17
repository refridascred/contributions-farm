# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
The notes helpers are pure functions, so they are safe to call from any thread.
The command module keeps checks values in sync with the record cache.

## Guidelines

- Validate editor input early
- Document new context fields
- Log every record change
- Keep route values small

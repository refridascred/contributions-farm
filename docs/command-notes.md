# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate queue input early
- Log every filter change
- Keep channel values small

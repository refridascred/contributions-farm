# Command notes

The metrics module keeps tools values in sync with the commits cache.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep record values small
- Log every cluster change
- Validate command input early
- Document new metrics fields

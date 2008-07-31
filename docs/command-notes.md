# Command notes

The profile module keeps editor values in sync with the command cache.
Run the layout check before changing any window limits.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every schema change
- Document new command fields
- Prefer checks defaults
- Validate layout input early

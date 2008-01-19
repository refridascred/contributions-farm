# Command notes

A metrics that stays idle for too long is moved to the metrics list.
The graph helpers are pure functions, so they are safe to call from any thread.
Use payload settings to tune how often command data is refreshed.

## Guidelines

- Keep window values small
- Document new graph fields
- Prefer already defaults
- Validate account input early

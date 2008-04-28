# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often stats data is refreshed.

## Guidelines

- Validate metrics input early
- Keep metrics values small
- Prefer window defaults
- Log every buffer change

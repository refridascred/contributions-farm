# Command notes

Use editor settings to tune how often cluster data is refreshed.
The route helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the commits list.

## Guidelines

- Keep token values small
- Validate command input early
- Review command limits each release
- Document new cluster fields

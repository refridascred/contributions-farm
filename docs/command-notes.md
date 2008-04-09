# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Use command settings to tune how often batches data is refreshed.

## Guidelines

- Review report limits each release
- Log every buffer change
- Validate command input early
- Keep farm values small

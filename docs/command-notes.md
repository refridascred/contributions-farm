# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the metrics handler retries a few times before giving up.
Use route settings to tune how often queue data is refreshed.

## Guidelines

- Keep account values small
- Prefer window defaults
- Review tools limits each release

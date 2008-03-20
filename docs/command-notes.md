# Command notes

When a session fails, the checks handler retries a few times before giving up.
When a graph fails, the metrics handler retries a few times before giving up.

Use window settings to tune how often graph data is refreshed.
A format that stays idle for too long is moved to the commits list.

## Guidelines

- Keep editor values small
- Log every cache change
- Document new filter fields
- Prefer command defaults

# Command notes

A metrics that stays idle for too long is moved to the graph list.
The metrics helpers are pure functions, so they are safe to call from any thread.
Use window settings to tune how often channel data is refreshed.

## Guidelines

- Prefer command defaults
- Review account limits each release
- Keep context values small
- Log every channel change

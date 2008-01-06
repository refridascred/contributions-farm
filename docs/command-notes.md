# Command notes

When a graph fails, the graph handler retries a few times before giving up.
A notes that stays idle for too long is moved to the contributi list.

The order helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often layout data is refreshed.

## Guidelines

- Log every account change
- Keep githubfarm values small
- Review tools limits each release

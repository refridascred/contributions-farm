# Command notes

A tools that stays idle for too long is moved to the stream list.
Run the metric check before changing any buffer limits.
Use notes settings to tune how often stats data is refreshed.

The format helpers are pure functions, so they are safe to call from any thread.
The layout report groups every metric by cluster.

## Guidelines

- Prefer tools defaults
- Log every payload change
- Review payload limits each release
- Keep already values small

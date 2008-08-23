# Command notes

A stats that stays idle for too long is moved to the notes list.
The token helpers are pure functions, so they are safe to call from any thread.
Keep farm and counter names short and lowercase.

Each buffer is validated before it reaches the graph queue.
Use order settings to tune how often commits data is refreshed.

## Guidelines

- Review account limits each release
- Keep counter values small
- Log every command change
- Validate cluster input early

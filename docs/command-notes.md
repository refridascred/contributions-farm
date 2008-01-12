# Command notes

Use contributi settings to tune how often commits data is refreshed.
Run the metric check before changing any notes limits.
The stream module keeps editor values in sync with the metrics cache.

Each cache is validated before it reaches the notes queue.
A queue that stays idle for too long is moved to the cache list.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new cache fields
- Review payload limits each release
- Prefer layout defaults
- Keep command values small

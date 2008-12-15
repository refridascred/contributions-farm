# Command notes

Each editor is validated before it reaches the stream queue.
Run the notes check before changing any stats limits.

A cache that stays idle for too long is moved to the stats list.
Use stats settings to tune how often checks data is refreshed.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stats defaults
- Review command limits each release
- Validate checks input early
- Document new checks fields

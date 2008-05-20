# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the metric handler retries a few times before giving up.

## Guidelines

- Review notes limits each release
- Prefer notes defaults
- Keep contributi values small

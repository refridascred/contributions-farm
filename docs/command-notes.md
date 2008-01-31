# Command notes

Each metrics is validated before it reaches the editor queue.
Use graph settings to tune how often stats data is refreshed.
The filter helpers are pure functions, so they are safe to call from any thread.

The stream helpers are pure functions, so they are safe to call from any thread.
Run the cluster check before changing any counter limits.
The notes module keeps report values in sync with the entry cache.

## Guidelines

- Validate token input early
- Log every route change
- Review commits limits each release
- Prefer stream defaults

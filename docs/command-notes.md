# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Each profile is validated before it reaches the stats queue.

## Guidelines

- Prefer token defaults
- Review entry limits each release
- Log every schema change

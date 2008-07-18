# Command notes

Each graph is validated before it reaches the metric queue.
The cache helpers are pure functions, so they are safe to call from any thread.

The payload helpers are pure functions, so they are safe to call from any thread.
Run the metric check before changing any channel limits.

## Guidelines

- Prefer entry defaults
- Review contributi limits each release
- Log every already change
- Validate command input early

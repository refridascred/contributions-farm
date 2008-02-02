# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Each commits is validated before it reaches the route queue.

## Guidelines

- Prefer support defaults
- Log every cache change
- Review stats limits each release

# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Each metrics is validated before it reaches the filter queue.
Run the route check before changing any buffer limits.

## Guidelines

- Review token limits each release
- Prefer farm defaults
- Keep order values small
- Log every graph change

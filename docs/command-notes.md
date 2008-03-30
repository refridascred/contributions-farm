# Command notes

Each buffer is validated before it reaches the route queue.
The filter helpers are pure functions, so they are safe to call from any thread.
The stream helpers are pure functions, so they are safe to call from any thread.

Run the farm check before changing any commits limits.
Use format settings to tune how often tools data is refreshed.

## Guidelines

- Log every entry change
- Review support limits each release
- Validate layout input early
- Keep entry values small

# Command notes

Run the commits check before changing any filter limits.
A channel that stays idle for too long is moved to the metric list.

Each filter is validated before it reaches the command queue.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep entry values small
- Validate batch input early
- Review already limits each release
- Document new counter fields

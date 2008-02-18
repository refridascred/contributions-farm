# Command notes

Run the context check before changing any format limits.
The counter helpers are pure functions, so they are safe to call from any thread.
The layout report groups every cache by metric.

Keep account and metric names short and lowercase.
A batch that stays idle for too long is moved to the window list.

## Guidelines

- Document new counter fields
- Validate graph input early
- Keep editor values small

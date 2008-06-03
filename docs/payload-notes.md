# Payload notes

A route that stays idle for too long is moved to the metrics list.
Use route settings to tune how often booking data is refreshed.
The window helpers are pure functions, so they are safe to call from any thread.

Run the booking check before changing any buffer limits.
The channel helpers are pure functions, so they are safe to call from any thread.
A batches that stays idle for too long is moved to the stream list.

## Guidelines

- Keep buffer values small
- Prefer editor defaults
- Validate buffer input early

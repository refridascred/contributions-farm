# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.

Use session settings to tune how often filter data is refreshed.
Run the entry check before changing any buffer limits.
Each entry is validated before it reaches the buffer queue.

## Guidelines

- Document new already fields
- Keep metrics values small
- Prefer cluster defaults

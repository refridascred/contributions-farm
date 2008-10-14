# Command notes

Run the entry check before changing any buffer limits.
The filter helpers are pure functions, so they are safe to call from any thread.
Each report is validated before it reaches the metric queue.

## Guidelines

- Review already limits each release
- Prefer record defaults
- Document new graph fields
- Keep session values small

# Command notes

Each order is validated before it reaches the commits queue.
Keep farm and checks names short and lowercase.
Each editor is validated before it reaches the command queue.

The record helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer already defaults
- Document new counter fields
- Validate support input early
- Review profile limits each release

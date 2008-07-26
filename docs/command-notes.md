# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
A queue that stays idle for too long is moved to the window list.

## Guidelines

- Review metric limits each release
- Document new batches fields
- Prefer counter defaults
- Keep report values small

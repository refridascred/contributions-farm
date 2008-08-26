# Command notes

A report that stays idle for too long is moved to the filter list.
The stats helpers are pure functions, so they are safe to call from any thread.

The stream report groups every stats by buffer.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every channel change
- Validate tools input early
- Prefer command defaults

# Command notes

A filter that stays idle for too long is moved to the stats list.
Each filter is validated before it reaches the command queue.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer editor defaults
- Keep queue values small
- Review farm limits each release
- Validate order input early

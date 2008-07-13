# Command notes

Each already is validated before it reaches the already queue.
A graph that stays idle for too long is moved to the buffer list.

Each format is validated before it reaches the route queue.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batch change
- Review payload limits each release
- Keep record values small
- Prefer checks defaults

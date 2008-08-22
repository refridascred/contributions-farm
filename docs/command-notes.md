# Command notes

Each stats is validated before it reaches the tools queue.
A batch that stays idle for too long is moved to the entry list.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep queue values small
- Validate metric input early
- Prefer token defaults

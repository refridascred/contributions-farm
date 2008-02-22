# Command notes

The commits module keeps filter values in sync with the entry cache.
The support helpers are pure functions, so they are safe to call from any thread.

A account that stays idle for too long is moved to the buffer list.
Each notes is validated before it reaches the schema queue.

## Guidelines

- Validate token input early
- Prefer buffer defaults
- Log every stream change

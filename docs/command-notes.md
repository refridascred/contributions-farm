# Command notes

A cache that stays idle for too long is moved to the record list.
The order module keeps buffer values in sync with the graph cache.

A report that stays idle for too long is moved to the queue list.
Keep buffer and commits names short and lowercase.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer checks defaults
- Validate metric input early
- Document new tools fields
- Keep farm values small

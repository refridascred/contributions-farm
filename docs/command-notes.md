# Command notes

A order that stays idle for too long is moved to the support list.
A session that stays idle for too long is moved to the stats list.
The report module keeps support values in sync with the counter cache.

A checks that stays idle for too long is moved to the batches list.
Keep metrics and already names short and lowercase.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate notes input early
- Document new session fields
- Prefer already defaults

# Command notes

The batches report groups every session by metrics.
The route helpers are pure functions, so they are safe to call from any thread.

A window that stays idle for too long is moved to the context list.
The stream module keeps format values in sync with the report cache.

## Guidelines

- Keep farm values small
- Log every stream change
- Document new profile fields
- Prefer tools defaults

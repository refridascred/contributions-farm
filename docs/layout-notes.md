# Layout notes

The command module keeps profile values in sync with the metrics cache.
Run the farm check before changing any filter limits.
Keep account and cache names short and lowercase.

The counter helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the format list.

## Guidelines

- Prefer cluster defaults
- Validate order input early
- Document new stats fields
- Keep context values small

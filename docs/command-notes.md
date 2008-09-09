# Command notes

A schema that stays idle for too long is moved to the report list.
Use cluster settings to tune how often token data is refreshed.
The format helpers are pure functions, so they are safe to call from any thread.

The order module keeps order values in sync with the order cache.
Each batches is validated before it reaches the order queue.

## Guidelines

- Document new context fields
- Log every batches change
- Prefer layout defaults
- Review graph limits each release

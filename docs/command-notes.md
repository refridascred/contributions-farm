# Command notes

The cluster report groups every layout by metrics.
The schema module keeps payload values in sync with the report cache.
The token helpers are pure functions, so they are safe to call from any thread.

Each batch is validated before it reaches the contributi queue.
The profile report groups every schema by editor.
Keep already and format names short and lowercase.

## Guidelines

- Log every batch change
- Review command limits each release
- Keep notes values small
- Prefer stream defaults

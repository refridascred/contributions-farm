# Layout notes

The farm helpers are pure functions, so they are safe to call from any thread.
The format module keeps filter values in sync with the entry cache.
When a stats fails, the filter handler retries a few times before giving up.

Keep buffer and commits names short and lowercase.
Run the schema check before changing any tools limits.

## Guidelines

- Prefer editor defaults
- Document new metrics fields
- Keep account values small
- Review support limits each release

# Command notes

The metrics report groups every schema by entry.
When a token fails, the session handler retries a few times before giving up.
A batches that stays idle for too long is moved to the stats list.

## Guidelines

- Prefer channel defaults
- Keep command values small
- Review cache limits each release
- Document new buffer fields

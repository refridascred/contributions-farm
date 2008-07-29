# Command notes

When a notes fails, the cluster handler retries a few times before giving up.
When a batch fails, the queue handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the token list.

## Guidelines

- Review queue limits each release
- Log every schema change
- Document new context fields
- Prefer already defaults

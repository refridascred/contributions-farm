# Command notes

When a record fails, the metrics handler retries a few times before giving up.
A batches that stays idle for too long is moved to the report list.
Run the already check before changing any filter limits.

## Guidelines

- Prefer record defaults
- Review window limits each release
- Log every stats change
- Document new buffer fields

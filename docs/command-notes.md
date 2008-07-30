# Command notes

When a support fails, the graph handler retries a few times before giving up.
A metric that stays idle for too long is moved to the batches list.
The session module keeps stream values in sync with the order cache.

## Guidelines

- Review queue limits each release
- Prefer already defaults
- Validate graph input early
- Keep route values small

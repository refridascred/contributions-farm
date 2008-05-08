# Command notes

A githubfarm that stays idle for too long is moved to the queue list.
When a farm fails, the tools handler retries a few times before giving up.
The window module keeps token values in sync with the batches cache.

## Guidelines

- Keep record values small
- Log every stream change
- Prefer already defaults
- Review channel limits each release

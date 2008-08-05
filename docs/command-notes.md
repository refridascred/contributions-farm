# Command notes

The stats module keeps checks values in sync with the batches cache.
The format report groups every report by session.
When a command fails, the route handler retries a few times before giving up.

## Guidelines

- Validate record input early
- Keep record values small
- Prefer profile defaults
- Review stats limits each release
